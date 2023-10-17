using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnLibrary.EntityFramework
{
    //Mục đích của class user là lấy ID và account name của người đăng nhập
    //Lưu username nhân viên tạo phiếu hoặc dùng để ẩn hiện chức năng theo quyền hạn
    public class User
    {
        private static string _AccountId;
        private static string _AccountName;
        public static string AccountId
        {
            get { return _AccountId; }
            set { _AccountId = value; }
        }
        public static string AccountName
        {
            get { return _AccountName; }
            set { _AccountName = value; }
        }
    }
}
