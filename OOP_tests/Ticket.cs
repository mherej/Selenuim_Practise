using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_tests
{
    public abstract class Ticket
    {
        protected DateTime DateOfEvent { get; set; }
        private string Description { get; set; }
        protected string Venue { get; set; }


        public Ticket(DateTime dateTime, string desc, string venue)
        {
            DateOfEvent = dateTime;
            Description = desc;
            Venue = venue;
        }

        public string GetVenue()
        {
            return this.Venue;
        }
        public DateTime GetEventDate()
        {
            return this.DateOfEvent;
        }
    }

    public class Play : Ticket
    {
       private string PlayTile { get; set; }
       private string Genre { get; set; }

    
        public Play(DateTime dateTime, string desc, string venue, string playTitle, string genre) : base(dateTime, desc, venue)
        {
            PlayTile = playTitle;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"Play Title - {PlayTile} Venue - {base.GetVenue()} date - {base.DateOfEvent}";
        }
    }
}
