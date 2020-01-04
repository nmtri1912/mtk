using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationFramework.TypeShow
{
    public class ListValidator
    {
        private ShowBehavior showBehavior = new MessBox();
        private List<Validator> validators = new List<Validator>();

        public ListValidator()
        {

        }

        public void AddValidator(Validator validator)
        {
            validators.Add(validator);
        }

        public void SetShowBehavior(ShowBehavior sb)
        {
            showBehavior = sb;
        }

        // ListValidator.SetShowBehavior(new MessageBox())
        // list.show()
        public void show()
        {
            string message = "";
            foreach (Validator va in validators)
            {
                message = message + va + "\n";
            }
            showBehavior.show(message);
        }
    }
}
