using System;
namespace Inheritance
{
    public class Birds : Animal 
    {
        public Birds() //Constructor
        {
            Vertebrates = true;
            Hibernates = false;
            HasFur = false;
            LaysEggs = true;
            string chordata = null;
            Phylum = chordata;
            string aves = null;
            Class = aves;
            Legs = 2;
            Arms = 0;
        }



        
        public bool Migratory { get; set; }
        public bool CantFly { get; set; }
        public bool IsEdible { get; set; }
        public bool Passerene { get; set; }
        
    }
}
