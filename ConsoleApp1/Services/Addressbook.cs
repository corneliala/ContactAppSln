using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public class Addressbook
    {
        public List<Contact> ContactList { get; set; } = new List<Contact>();
    }
}
