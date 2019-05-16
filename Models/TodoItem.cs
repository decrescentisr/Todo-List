using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Class that initiates values for Id, Name, IsComplete within getters and setters

namespace WebAPIDemo.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
