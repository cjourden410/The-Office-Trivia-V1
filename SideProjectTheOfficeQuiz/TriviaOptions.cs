using SideProjectTheOfficeQuiz.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SideProjectTheOfficeQuiz
{
    public class TriviaOptions
    {
        public static Trivia DunderMifflin
        {
            get
            {
                return new Trivia()
                {
                    Name = "Dunder Mifflin",
                    Questions = new List<Question>()
                    {
                        new MultipleChoiceQuestions("What color t-shirt did the Scranton branch wear at the company picnic?", "D",
                        new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "Green" },
                            {"B", "Orange" },
                            {"C", "Dark Blue" },
                            {"D", "Red" },
                            {"E", "Dark Purple" },
                        }),
                        new MultipleChoiceQuestions("What was the original air date of the first episode?", "A",
                        new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "March 24, 2005" },
                            {"B", "April 8, 2005" },
                            {"C", "March 19, 2004" },
                            {"D", "April 1, 2004" },
                            {"E", "March 22, 2005" },
                        }),
                        new MultipleChoiceQuestions(@"In the episode “Trivia”, which of the following was not a team that participated in trivia night?", "B",
                        new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "Dunder Mifflin A-Team" },
                            {"B", "Tequila Mockingbird" },
                            {"C", "Queerenstein Bears" },
                            {"D", "Two Broke Dorks" },
                            {"E", "The Einsteins" },
                        }),
                        new MultipleChoiceQuestions(@"In the episode “Costume Contest” who ended up winning the Scranton-area coupon book with a total of $15,000 in savings?", "B",
                        new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "Gabe" },
                            {"B", "Oscar " },
                            {"C", "Creed" },
                            {"D", "Kelly" },
                            {"E", "Kevin" },
                        }),
                        new MultipleChoiceQuestions("Which of the following was not included in Pam’s portfolio during her art gallery presentation?", "D",
                        new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "The Scranton Business Park" },
                            {"B", "A Vase of Flowers" },
                            {"C", "A Stapler" },
                            {"D", "A Mug Filled with Pens" },
                            {"E", "A Bowl of Fruit" },
                        })
                    }
                };
            }
        }
        public static Trivia RegionalManagers
        {
            get
            {
                return new Trivia()
                {
                    Name = "Regional Managers",
                    Questions = new List<Question>()
                {
                    new MultipleChoiceQuestions("Of the below, what was not included on the Fun Run t-shirt?", "B",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                        {"A", "Fun Run Race" },
                        {"B", "Michael Scarn" },
                        {"C", "Celebrity Rabies Awareness" },
                        {"D", "Pro-Am" },
                        {"E", "Scranton" },
                    }),
                    new MultipleChoiceQuestions("Which of the following will you not find on Michael’s desk?", "E",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                        {"A", "Blue Train Car" },
                        {"B", "Newton’s Cradle" },
                        {"C", "Pink Fez Hat" },
                        {"D", "Dunder Mifflin Toy Semi Truck" },
                        {"E", "Zen Garden" },
                    }),
                    new MultipleChoiceQuestions("How many months was Andy gone on his sailing trip?", "D",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "2" },
                            {"B", "1" },
                            {"C", "4" },
                            {"D", "3" },
                            {"E", "5" },
                        }),
                    new MultipleChoiceQuestions("When Michael assumes that Donna is cheating on him, what is he eating when Jim and Pam run into him in the breakroom?", "A",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "Mayonnaise and Black Olives" },
                            {"B", "Yogurt " },
                            {"C", "Sour Cream and Onions" },
                            {"D", "Ice Cream" },
                            {"E", "Ice Cream Cake" },
                        })
                }
                };
            }
        }

        public static Trivia Sales
        {
            get
            {
                return new Trivia()
                {
                    Name = "Sales",
                    Questions = new List<Question>()
                {
                    new MultipleChoiceQuestions("Which Halloween costume has Jim Halpert not worn?", "D",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "Three Hole Punch Jim" },
                            {"B", "Popeye" },
                            {"C", "Chris Bosh" },
                            {"D", @"“David”" },
                            {"E", "Facebook" },
                        }),
                    new MultipleChoiceQuestions(@"What was the name Jim used for his “The Ultimate Guide to Throwing a Garden Party” book?", "A",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "Jim Trickington" },
                            {"B", "Jim Prankerington" },
                            {"C", "Jim Trickerington" },
                            {"D", "Jim Prankington" },
                            {"E", "Jimothy Prankston" },
                        }),
                    new MultipleChoiceQuestions("What does Todd Packer’s vanity license plate say?", "D",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "IM Hung" },
                            {"B", "4GoodTime" },
                            {"C", "Packman" },
                            {"D", "WL Hung" },
                        }),
                    new MultipleChoiceQuestions("When staying at The Schrute Farms Bed and Breakfast, what did Jim say were the changes that he and Pam would be murdered?", "D",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "3 in 10" },
                            {"B", "2 in 6" },
                            {"C", "1 in 5" },
                            {"D", "1 in 6" },
                            {"E", "1 in 8" },
                        }),
                    new MultipleChoiceQuestions("What song does Dwight play Michael for his birthday on his recorder?", "A",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "The Longest Time" },
                            {"B", "Happy Birthday" },
                            {"C", "Just The Way You Are" },
                            {"D", "My Life" },
                            {"E", "Shout" },
                        }),
                }
                };
            }
        }

        public static Trivia TheAnnex
        {
            get
            {
                return new Trivia()
                {
                    Name = "The Annex",
                    Questions = new List<Question>()
                {
                    new MultipleChoiceQuestions("What was the cause of Toby’s injury that put him in the hospital during his trip to Costa Rica?", "B",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "Fell getting off the plane" },
                            {"B", "Zipline Incident" },
                            {"C", "Hiking Incident" },
                            {"D", "Scuba Diving Malfunction" },
                            {"E", "Bungie Jumping Incident" },
                        }),
                    new MultipleChoiceQuestions("Which of the following never sat in the Annex?", "E",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "Jim" },
                            {"B", "Ryan" },
                            {"C", "Dwight" },
                            {"D", "Holly" },
                            {"E", "Pam" },
                        }),
                    new MultipleChoiceQuestions("Kevin’s band mostly covers music from which band?", "B",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "The Who" },
                            {"B", "The Police" },
                            {"C", "Phil Collins" },
                            {"D", "U2" },
                            {"E", "Duran Duran" },
                        }),
                    new MultipleChoiceQuestions("What is Kevin’s favorite movie?", "A",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "American Pie 2" },
                            {"B", "Zoolander" },
                            {"C", "Varsity Blues" },
                            {"D", "Joe Dirt" },
                            {"E", "Rush Hour 2" },
                        }),
                    new MultipleChoiceQuestions("What is the name of Kevin’s band?", "D",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "Net Present Value" },
                            {"B", "Be Audit You Can Be" },
                            {"C", "Kevin and the Zits" },
                            {"D", "Scrantonicity" },
                            {"E", "LIFO" },
                        })
                }
                };
            }
        }

        public static Trivia Corporate
        {
            get
            {
                return new Trivia()
                {
                    Name = "Corporate",
                    Questions = new List<Question>()
                {
                    new MultipleChoiceQuestions("After David Wallace buys Dunder Mifflin, what name does Robert California introduce himself with?", "A",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "Bob Kazamakis" },
                            {"B", "Robert California" },
                            {"C", "Robert Cranston" },
                            {"D", "Bob Acula" },
                            {"E", "Rob Kirilenko" },
                        }),
                    new MultipleChoiceQuestions("The first time Jo Bennet’s comes to the Scranton Branch, what is the breed of the two dogs with her?", "B",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "One Sheltie and One Great Dane" },
                            {"B", "Two Great Danes" },
                            {"C", "Two Shelties" },
                            {"D", "One Yellow Lab and One Sheltie" },
                            {"E", "One Yellow Lab and One Great Dane" },
                        }),
                    new MultipleChoiceQuestions("Which of the following was not on the Corporate Volleyball team during the company retreat?", "D",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "David Wallace" },
                            {"B", "Charles Minor" },
                            {"C", "Paul Kendall" },
                            {"D", "Thomas Dean" }
                        }),
                    new MultipleChoiceQuestions("What is the name of the receptionist at the Dunder Mifflin corporate office?", "E",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "Ronni" },
                            {"B", "Rolando" },
                            {"C", "Polly" },
                            {"D", "Emily" },
                            {"E", "Grace " },
                        }),
                    new MultipleChoiceQuestions("What was the name of Jan’s assistant Hunter’s band?", "B",
                    new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){
                            {"A", "The Wanted" },
                            {"B", "The Hunted" },
                            {"C", "Lights Out Houston" },
                            {"D", "The Unforgiven" },
                            {"E", "Tue Days from Twosday" }
                        })
                }
                };
            }
        }
        // nothing below this line
    }
}
