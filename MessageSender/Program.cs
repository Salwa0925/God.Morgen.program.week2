

namespace MessageSender;

class Program
{
     private static DayOfWeek dayGreetingHelper = new DayOfWeek();


    //Used this to send a standard message with real time date.
    static void Main(string[] args)
    {
        var daygreetinghelper = new DayOfWeek();
        daygreetinghelper.MessageOFTheDay();     //Used this to send a standard message with real time date.
        
        Console.WriteLine("Please logg in here!");
        string brukernavn = Console.ReadLine() ?? "";

        //To prevent an empty username.
        while (string.IsNullOrWhiteSpace(brukernavn))
        {
            Console.WriteLine("No username entered.");
            Console.WriteLine("Please try again!");
            brukernavn = Console.ReadLine();
        }


         // Using (for) to reapete the (char) with the (string Days)in the code.
        for (int i = 0; i < daygreetinghelper.Days.Length; i++)
        {

            var daylycharacters = daygreetinghelper.Characters[i % daygreetinghelper.Characters.Length];
            

         //For the program to connect the username to the message i used if statemant. (Help from ChatGPT)
            if (Array.Exists(daylycharacters, c => c == char.ToLower(brukernavn[0])))
            {
                Console.WriteLine(dayGreetingHelper.FetchMessageBasedOnLetter(brukernavn[0]));
            }
        }
     
    }


    
    public class DayOfWeek
    {

        //To find the date IRT
        public DateTime Today = DateTime.Now;
        

        //Public void becouse this will be a standard start message 
        // that wont be used anywhere else in the program.
        public void MessageOFTheDay()
        {
            string Message = ($"Good Morning today is ({Today:dddd, MMMM dd yyyy})! Have a blessed day.");
            Console.WriteLine(Message);
        }



        public string[] Days =
        ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday","Sunday"];

        public char[][] Characters =
         [
            ['a', 'f', 'k', 'p', 'u'],
            ['b', 'g', 'l', 'q', 'v'],
            ['c', 'h', 'm', 'r', 'w'],
            ['d', 'i', 'n', 's', 'x'],
            ['e', 'j', 'o', 't', 'y', 'z'],
        ];



 // Fetch message based on letter (Help from ChatGPT)
    public string FetchMessageBasedOnLetter(char initial)
    {
        initial = char.ToLower(initial);
        int dayIndex = (int)DateTime.Now.DayOfWeek; // 

        for (int i = 0; i < Characters.Length; i++)
        {   
            if (Array.Exists(Characters[i], c => c == initial)) //her ser den om første bokstaven er i ett existing array. 
            {
                int index = (i + dayIndex) % MessagesList.Length;
                return MessagesList[index]; //retunerer en melding basert på hvilken dag det er.
            }
        
        }

        return "Have a great day full of unexpected blessings!";
    }   
        public string[] MessagesList =
            [
                "The only way to do great work is to love what you do.", 

                "It always seems impossible until it's done.", 

                "Your time is limited, don't waste it living someone else's life.",  

                "The best time to plant a tree was 20 years ago. The second best time is now.", 

                "The future belongs to those who believe in the beauty of their dreams.",


            ];

    }

}



