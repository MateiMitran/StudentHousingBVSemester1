using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingBV
{
    public class Banks
    {
        public String name;
        private int balance;

        public Banks(String name,int balance)
        {
            this.name = name;
            this.balance = balance;
            
        }

        public Banks(int balance)
        {
            this.balance = balance;
        }

        /// <summary>
        /// Here it should be changed in a way that the name automatically becomes the one of the user
        /// </summary>
        /// <param name="name"></param>
        public void setBankOwner(TenantClass t)
        {
            //Tenant Name = this.getName();
            this.name = t.getName();
        }

        public String getBankOwner()
        {
            return this.name;
        }

        public void SetBalance(int value)
        {
            this.balance = value;
        }

        public void initBank(String name, int balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public void addMoney(int value)
        {
            this.balance += value;
        }

        public String getInfo()
        {
            string holder;
            holder = this.name + "-" + this.balance;

            return holder;
        }
    }
}
