namespace PetManagement {
    public class PetEvents {
        public delegate void PetFeedHandler(Pet Pet);
        public delegate void PetPlayHandler(Pet Pet);
        public delegate void PetSleepHandler(Pet Pet);

        public event PetFeedHandler Feed;
        public event PetPlayHandler Play;
        public event PetSleepHandler Sleep;

        public void OnFeed(Pet pet) {
            if (Feed != null) {
                Feed(pet);
            }
        }

        public void OnPlay(Pet pet) {
            if (Play != null) {
                Play(pet);
            }
        }

        public void OnSleep(Pet pet) {
            if (Sleep != null) {
                Sleep(pet);
            }
        }
    }
}
