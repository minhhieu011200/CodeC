using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    class Author
    {
        protected string name;
        protected string email;
        protected string gender;
        public Author(string name,string email,string gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender ;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string email)
        {
            this.email =email;
        }
        public string getGender()
        {
            
             return gender;
            
        }
        public void setGender(string m)
        {
            this.gender = m;
        }
        public virtual string toString()
        {
            return "name="+ name + ",email=" + email + ",gender=" + gender;
        }
     



    }
}
