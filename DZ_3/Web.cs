using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3
{
    public  class Web
    {
        public Web() { }
        public string Name_ { get; set; }
        public string Url_ { get; set; }
        public string Description_ {  get; set; }
        public string IP_ {  get; set; }
        public string Name() { return Name_; }
        public string Url() { return Url_; }
        public string Description() { return Description_; }
        public string IP() { return IP_; }

        public void Print()
        {
            Console.WriteLine($"Имя сайта:{Name_}\nUrl сайта:{Url_}\nОписание сайта:{Description_}\nIP сайта{IP_}");
        }


    }
}
