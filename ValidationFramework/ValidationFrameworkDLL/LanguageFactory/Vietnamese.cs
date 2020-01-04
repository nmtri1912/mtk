using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationFramework.LanguageFactory
{
    public class Vietnamese : LanguageNotification
    {
        public string getErrorMessage(int code)
        {
            switch (code)
            {
                case 1:
                    return "không phải mảng rỗng";
                case 2:
                    return "Là mảng rỗng";
                case 3:
                    return "Không lớn hơn";
                case 4:
                    return "Không lớn hơn hoặc bằng";
                case 5:
                    return "Không nhỏ hơn";
                case 6:
                    return "Không nhỏ hơn hoặc bằng";
                case 7:
                    return "Vượt số ký tự cho phép";
                case 8:
                    return "Quá ít ký tự";
                case 9:
                    return "Nằm ngoài khoảng";
                case 10:
                    return "Nằm ngoài đoạn";
                case 11:
                    return "Số điện thoại không hợp lệ";
                case 12:
                    return "Thẻ Tín dụng không hợp lệ";
                case 13:
                    return "Email không hợp lệ";
                case 14:
                    return "Tối thiểu 8 ký tự, ít nhất một chữ cái và một số";
                case 15:
                    return "Không bằng";
                case 16:
                    return "Đã bằng";
                case 17:
                    return "'{0}' is not a valid date.";
                case 18:
                    return "'{0}' failed the provided business rule provided.";
                case 19:
                    return "'{0}' must be greater than '{1}'.";
                case 20:
                    return "'{0}' must be greater than or equal to '{1}'.";
                case 21:
                    return "'{0}' must be less than '{1}'.";
                case 22:
                    return "'{0}' must be less than or equal to '{1}'.";
                case 23:
                    return "'{0}' must be equal to '{1}'.";
                case 24:
                    return "'{0}' must be between '{1}' and '{2}' (inclusive).";
                case 25:
                    return "'{0}' must be between '{1}' and '{2}' (exclusive).";
            }
            return null;
        }
    }
}
