from flask import Flask, request, render_template, redirect
import os
from PIL import Image
import imagehash
from docx import Document

app = Flask(__name__)
UPLOAD_FOLDER = 'static/uploads'
DATA_FOLDER = 'data'
SIMILARITY_THRESHOLD = 0.8

# Load hash of existing images
def load_image_hashes():
    hashes = {}
    for filename in os.listdir(DATA_FOLDER):
        if filename.lower().endswith(('.png', '.jpg', '.jpeg')):
            path = os.path.join(DATA_FOLDER, filename)
            try:
                img_hash = imagehash.average_hash(Image.open(path))
                hashes[filename] = img_hash
            except:
                continue
    return hashes

def read_docx(filename):
    path = os.path.join(DATA_FOLDER, filename)
    if os.path.exists(path):
        doc = Document(path)
        return '\n'.join([p.text for p in doc.paragraphs])
    return "[No description found]"

@app.route('/', methods=['GET', 'POST'])
def index():
    image_hashes = load_image_hashes()
    results = []

    if request.method == 'POST':
        if 'compare' in request.form:
            file = request.files['image']
            if file:
                filepath = os.path.join(UPLOAD_FOLDER, file.filename)
                file.save(filepath)

                uploaded_hash = imagehash.average_hash(Image.open(filepath))

                for fname, stored_hash in image_hashes.items():
                    similarity = 1 - (uploaded_hash - stored_hash) / len(uploaded_hash.hash) ** 2
                    if similarity >= SIMILARITY_THRESHOLD:
                        doc_name = fname.rsplit('.', 1)[0] + '.docx'
                        description = read_docx(doc_name)
                        results.append({'image': fname, 'desc': description, 'score': round(similarity*100, 2)})

        elif 'add_new' in request.form:
            new_image = request.files.get('new_image')
            new_doc = request.files.get('new_doc')
            if new_image and new_doc:
                image_path = os.path.join(DATA_FOLDER, new_image.filename)
                doc_path = os.path.join(DATA_FOLDER, new_doc.filename)
                new_image.save(image_path)
                new_doc.save(doc_path)
                return redirect('/')

    return render_template('index.html', results=results)

if __name__ == '__main__':
    os.makedirs(UPLOAD_FOLDER, exist_ok=True)
    os.makedirs(DATA_FOLDER, exist_ok=True)
    app.run(debug=True)
