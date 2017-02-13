using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5T4
{
    class Mail
    {
        public string MailType { get; set; }

        public override string ToString()
        {
            return MailType + "\n";
        }
    }
    class Mailbox
    {
        private List<Mail> mail = new List<Mail>();
        private string color = "Red";
        private string name;

        public string Color { get { return color; } }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public void AddMail(Mail m)
        {
            mail.Add(m);
        }
        public void RemoveMail()
        {
            mail.Clear();
        }
        public override string ToString()
        {
            string temp = "";
            foreach (Mail m in mail)
            {
                temp += m;
            }
            return "Mailbox: " + name + ", has mail:\n" + temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mailbox one = new Mailbox();

            Mail a = new Mail();
            a.MailType = "Letter";
            Mail b = new Mail();
            b.MailType = "Newspaper";
            Mail c = new Mail();
            c.MailType = "Advertisement";
            Mail d = new Mail();
            d.MailType = "Death threat";

            one.Name = "Mallikas";
            one.AddMail(a);
            one.AddMail(b);
            one.AddMail(c);
            one.AddMail(d);

            Console.WriteLine(one.ToString());

            one.RemoveMail();
            Console.WriteLine(one.ToString());
        }
    }
}
