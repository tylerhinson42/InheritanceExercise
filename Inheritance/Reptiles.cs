using System;
namespace Inheritance
{
    public class Reptiles : Animal 
    {
        public Reptiles()
        {
            Vertebrates = true;
            Hibernates = false;
            HasFur = false;
            LaysEggs = true;
            string chordata = null;
            Phylum = chordata;
            string reptilia = null;
            Class = reptilia;
            Legs = 0;
            Arms = 0;
            HasSkin = false;
        }



        
            public string color { get; set; }
            public bool IsNotExtinct { get; set; }
            public bool IsDiapsid { get; set; }  //Includes all crocidiles, snakes, lizards, dinosaurs, and BIRDS
            public bool Elapids { get; set; }

      

        
    }
}
