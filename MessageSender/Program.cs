namespace AlphLetter;

class Program
{
    static void Main(string[] args)
    {
        var daygreetinghelper = new DayOfWeek();
        daygreetinghelper.MessageOFTheDay();

        Console.WriteLine("Hello, Please logg in here!");
        Console.ReadLine();

        for (int i = 0; i < daygreetinghelper.Days.Length; i++)
        {
            Console.WriteLine(daygreetinghelper.Days[i]);

            var daylycharacters = daygreetinghelper.Characters[i % daygreetinghelper.Characters.Length][0];
            Console.WriteLine(daylycharacters);
        }

     
    }



    public class DayOfWeek
    {

        public void MessageOFTheDay()
        {
            string Message = ($"Good Morning today is ({Today:dddd, MMMM dd yyyy})! Have a blessed day.");
            Console.WriteLine(Message);
        }
        

        public DateTime Today = DateTime.Now;

        public string[] Days = ["Monday", "Tusday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];
        //List <String> days = ["Monday", "Tusday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];

        public char[][] Characters =
         [
            ['A', 'F', 'K', 'P', 'U']
            ['B', 'G', 'L', 'Q', 'V']
            ['C', 'H', 'M', 'R', 'W']
            ['D', 'I', 'N', 'S', 'X']
            ['E', 'J', 'O', 'T', 'Y', 'Z']
        ];

        
        public string[][] MessageA = [
                ["Today is for fresh starts and infinite possibilities. Embrace them with new energy!"]

                ["Keep building momentum from yesterday. today is the day to make real progress." ]

                ["Hump day is here! You're halfway there. Keep pushing through with focused effort."]

                ["Now is a great time to reflect on your progress and plan for an even better day."]

                ["Take time today to celebrate your wins and finish the week strong."]


         ];
       
        

        
  
    }



}
