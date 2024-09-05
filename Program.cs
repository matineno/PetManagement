namespace PetManagement {
    internal class Program {
        static void Main(string[] args) {
            PetEvents petEvents = new PetEvents();


            Pet pet = new Pet();
            Console.WriteLine("What is your pet's name?");
            pet.Name = Console.ReadLine();

            petEvents.Feed += FeedPet;
            petEvents.Play += PlayPet;
            petEvents.Sleep += SleepPet;

            bool exit = false;

            while (!exit) {
                Console.WriteLine("\nWelcome to the Pet Simulator");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Feed your pet");
                Console.WriteLine("2. Play with your pet");
                Console.WriteLine("3. Put your pet to sleep");

                string userInput = Console.ReadLine();
                if (userInput == "1") {
                    petEvents.OnFeed(pet);
                }
                else if (userInput == "2") {
                    petEvents.OnPlay(pet);
                }
                else if (userInput == "3") {
                    petEvents.OnSleep(pet);
                }
                else {
                    Console.WriteLine("Invalid input: Input a number between 1 - 3");
                }
            }
        }

        public static void FeedPet(Pet pet) {
            pet.HungerLevel -= 10;
            pet.HappinessLevel += 10;
            Console.WriteLine($"You sucessfully fed {pet.Name}");
            Console.WriteLine("Hunger Level: " + pet.HungerLevel);
            Console.WriteLine("Happiness Level: " + pet.HappinessLevel);
            Console.WriteLine("Energy Level: " + pet.EnergyLevel);
        }

        public static void PlayPet(Pet pet) {
            pet.HappinessLevel += 10;
            pet.EnergyLevel -= 10;
            Console.WriteLine($"You played with {pet.Name}! Fun");
            Console.WriteLine("Hunger Level: " + pet.HungerLevel);
            Console.WriteLine("Happiness Level: " + pet.HappinessLevel);
            Console.WriteLine("Energy Level: " + pet.EnergyLevel);
        }

        public static void SleepPet(Pet pet) {
            pet.EnergyLevel += 10;
            pet.HappinessLevel -= 1;
            Console.WriteLine($"{pet.Name} is sleeping");
            Console.WriteLine("Hunger Level: " + pet.HungerLevel);
            Console.WriteLine("Happiness Level: " + pet.HappinessLevel);
            Console.WriteLine("Energy Level: " + pet.EnergyLevel);
        }

    }
}
