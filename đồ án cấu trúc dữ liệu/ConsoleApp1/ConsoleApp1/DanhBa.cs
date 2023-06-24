using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DanhBa
    {
        private string id;
        private string nickname;
        private string phonenumber;
        private string email;
        private string facebook;
        private string birthday;
        private string sex;


        public DanhBa(string id, string nickname, string phonenumber, string email, string facebook, string birthday, string sex)
        {
            this.id = id;
            this.nickname = nickname;
            this.phonenumber = phonenumber;
            this.email = email;
            this.facebook = facebook;
            this.birthday = birthday;
            this.sex = sex;

        }
        public string GetEmail()
        {
            return this.email;
        }
        public string GetFaceBook()
        {
            return this.facebook;
        }

        public string GetPhonenumber()
        {
            return this.phonenumber;
        }
        public string GetNickname()
        {
            return this.nickname;
        }
        public string GetId()
        {
            return this.id;
        }
        public string GetSex()
        {
            return this.sex;
        }
        public string GetBirth()
        {
            return this.birthday;
        }
        public override string ToString()
        {
            return($"{this.id,5}|    {this.nickname,7}|    {this.phonenumber,10}|    {this.birthday,9}");
        }
    }
}
