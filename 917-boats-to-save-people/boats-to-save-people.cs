public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people); // Step 1: Sort the array

        int left = 0;               // Lightest person
        int right = people.Length - 1; // Heaviest person
        int boats = 0;

        while (left <= right) {
            // Try to pair the lightest and heaviest
            if (people[left] + people[right] <= limit) {
                left++; // They can go together
            }

            // Heaviest person always goes (either alone or with someone)
            right--;
            boats++; // One boat used
        }

        return boats;
    }
}
