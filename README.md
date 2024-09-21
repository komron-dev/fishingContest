# Fishing Contest

This is a C# console application that simulates a fishing contest where anglers catch different types of fish. The program reads contest and angler data from text files, organizes the contest, and calculates the results based on the type and weight of the fish caught by each angler.

## Features

- **Organize Fishing Contests:** Register anglers to fishing clubs and contests.
- **Track Catches:** Record the fish species and weight caught by each angler.
- **Score Calculation:** Calculate each angler's score based on the type of fish and the weight of the catch.
- **Multiple Contests:** Handle multiple contests with different participants and results.

## Project Structure

```plaintext
fishingContest/
│
├── Program.cs         # Entry point of the application
├── Club.cs            # Manages the fishing club and angler memberships
├── Contest.cs         # Handles the organization and registration of fishing contests
├── Angler.cs          # Represents an angler who participates in contests
├── Catch.cs           # Represents a catch made by an angler (fish + weight)
├── Fish.cs            # Abstract class for different fish types (Bream, Carp, Catfish)
├── contests.txt       # Input file for the list of contests and anglers
├── input.txt          # Additional input data for testing
├── contest1.txt       # Data for contest 1 (fish species, weights)
├── contest2.txt       # Data for contest 2 (fish species, weights)
├── contest3.txt       # Data for contest 3 (fish species, weights)
└── fishingContest.sln # Visual Studio solution file
```

## Class Breakdown
- **Program.cs:** The main program logic. It reads contest data from text files, registers anglers, organizes contests, and calculates scores.
- **Club.cs:** Manages the fishing club, registering anglers and ensuring they are members.
- **Contest.cs:** Organizes individual contests and handles the registration of anglers for each contest.
- **Angler.cs:** Represents an angler and manages their participation in contests.
- **Catch.cs:** A data class that holds details about an angler’s catch (fish type and weight).
- **Fish.cs:** An abstract base class for different fish species. Specific fish types like `Bream`, `Carp`, and `Catfish` inherit from this class and have different score multipliers.

## How to Run
### 1. Clone the repository:

```
git clone https://github.com/yourusername/fishingContest.git
```

### 2. Open the solution in Visual Studio:

- Open `fishingContest.sln` in Visual Studio.

### 3. Build and Run(shortcuts are for Windows):

- Build the solution (Ctrl + Shift + B).
- Run the application (F5 or Start Debugging).

### 4. Provide Input Files: 
  Ensure that the input files (contests.txt, contest1.txt, contest2.txt, contest3.txt) are present in the root directory.
#### Example of input file
Each contest file (e.g., contest1.txt, contest2.txt) contains the name of the contest, followed by lines of angler names, fish species, and weights.
```
Summer Contest
John Doe
bream 2.5
Jane Smith
carp 3.0
```
