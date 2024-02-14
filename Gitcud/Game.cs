using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gitcud
{
    internal class Game//Item
    {
        private static int idCount = 0;

        private int id;
        private string title;//title
        private string type;//weigh {double}
        private int releaseYear;//price

        public Game()
        {
            this.id = ++idCount;
        }

        public Game(string title, string type, int releaseYear)
        {
            this.id = ++idCount;
            this.title = title;
            this.type = type;
            this.releaseYear = releaseYear;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int ReleaseYear
        {
            get { return releaseYear; }
            set { releaseYear = value; }
        }
        public override string ToString()
        {
            return $"{id}: {title} {type} {releaseYear}";
        }




















    }

}

