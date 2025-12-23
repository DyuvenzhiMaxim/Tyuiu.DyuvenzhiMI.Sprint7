

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tyuiu.DyuvenzhiMI.Sprint7.Project.V11.Lib
{
    public class DataService
    {
        public bool BoolValid(string FIO, string Addres, string Tel,
            string Birth, string Job, string Exp, string Educ, string Pay)
        {
            int intFIO;  int intTel; int intExp; int intPay;
            if ((int.TryParse(Tel, out intTel) == false) ||
                (int.TryParse(Exp, out intExp) == false) ||
                    (int.TryParse(Pay, out intPay) == false) ||
                    (int.TryParse(FIO, out intFIO) == true))
            {
                return false;
            }
            else if (Convert.ToInt32(Tel) <= 0 ||
                    Convert.ToInt32(Exp) < 0 ||
                    Convert.ToInt32(Pay) < 0)
            {
                return false;
            }

            return true;
        }
    }
}
