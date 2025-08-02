namespace Inheritance;
    

    public class Bird : Animal
    {
        public Bird()

        {
            IsAlive = true;
            BreathOxygen = true;
            CanMove = true;
            Age = 0;
            Name = "Bird";
            IsColdBlooded = false;
        }

        public bool LayEggs { get; set; }
        public string FeatherColor { get; set; }
        public bool CanFly { get; set; }
        public bool HaveLegs { get; set; }
    }
