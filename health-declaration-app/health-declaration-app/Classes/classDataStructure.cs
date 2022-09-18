using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_declaration_app
{

    struct structUser
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime dob { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }

    struct structHDResponse
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public bool question_01 { get; set; }
        public bool question_02 { get; set; }
        public bool question_03 { get; set; }
        public bool question_04 { get; set; }
        public bool question_05 { get; set; }
        public bool approved { get; set; }
    }

    struct structBooking
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string room_no { get; set; }
        public DateTime date { get; set; }
        public bool approved { get; set; }
    }

        
    struct structReportView
    {
        public int id { get; set; }
        public string name { get; set; }
        public string room_no { get; set; }
        public DateTime date { get; set; }
    }

}
