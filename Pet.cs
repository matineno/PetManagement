namespace PetManagement {
    public class Pet {
        public string Name { get; set; }
        public int HungerLevel { get; set; }
        public int HappinessLevel { get; set; }
        public int EnergyLevel { get; set; }
        public Pet() {
            HungerLevel = 50;
            HappinessLevel = 50;
            EnergyLevel = 50;
        }
    }
}
