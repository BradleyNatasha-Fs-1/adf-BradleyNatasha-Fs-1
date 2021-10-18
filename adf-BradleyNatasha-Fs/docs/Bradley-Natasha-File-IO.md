# Instructions 
Update this document where indicated (brackets). Replace text inside the brackets with your own information. For example: Course Name should be the name of this course, and not the generic words "Course Name".

**Note:** As you complete each item, also update reference links where indicated below. 

<br>

## [ Project and Portfolio 1: ADF ] 

* **[ File I/O ]**
* **[ Natasha Bradley ]**
* **[ 10/17/2021 ]**

This paper addresses some of the topic matter covered in research and activity this week. Be sure to include reference links below to the research and information you used to complete this assignment.

## Topic: Working with Data
Update the information below to demonstrate your knowledge on this topic.   

**1. Using Dictionary values as a Data Source.**

A dictionary is useful for working with data. Identify what's wrong with the code block below. How would you fix the issue(s)? The output to console should match the "**Expected Output**" shown below. 

Identify at least three issues with the code and how each can be fixed... 

- **Issue 1:** [ I dont see the using system.Collections.Generic being used which allows you to use dictionaries. I would just put it at the top. ]  
- **Issue 2:** [ if you want the concol to change color you have to clear it after but the expected output doesnt show the color needing to be changed so i would take that out. what i think they ment to put is consol.write. ]  
- **Issue 3:** [ nothing is stored in "SQL". i would just go back and add "Practical SQL" to "SQL". ]

  
    
```c#
            Dictionary<string, List<string>> myBooks = new Dictionary<string, List<string>>()
            {
                { "C", new List<string>()},
                { "JavaScript", new List<string>() },
                { "SQL", new List<string>() }
            };

            myBooks["C#"].Add("Visual C# Step by Step");
            myBooks["JavaScript"].Add("Learning JavaScript Design Patterns");

            foreach (KeyValuePair<string, List<string>> item in myBooks)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n*** {item} *******");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var book in item.Value)
                {
                    Console.WriteLine(book);
                }
            }

```

**Expected Output:** 

```
*** C# *******
Visual C# Step by Step

*** JavaScript *******
Learning JavaScript Design Patterns

*** SQL *******
Practical SQL

```

<br>


**2. Using a User object as a data source**

A dictionary can store objects. Imagine a User class that contains the following properties: **Name**, **City**, **State**, and **Id**. The code block below instantiates a new instance of this class and gives that instance (i.e. the new user object) some values. With that new object created, we add it to a dictionary. We then cycle through the dictionary to print out the new user object values to the console. 

Identify what's wrong with the code block below. How would you fix the issue(s)? The output to console should match the "**Expected Output**" shown below. 

Identify at least three issues with the code and how each can be fixed... 

- **Issue 1:** [ They using consol command to change the color instead of using the console.writeline. ]  
- **Issue 2:** [
     public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Id { get; set; } should be in a method but at the top above the methods. ]  
- **Issue 3:** [ i wouldnt save "John Doe", "Winter Park", "Florida", 1234) to where we instiantiate the user. instead id set it to out properties name,city, state and id in the main method.]

 
```c#
using System;
using System.Collections.Generic;

namespace Lab
{
    public class App
    {
        public App()
        {
            User user = new User("John Doe", "Winter Park", "Florida", 1234);

            Dictionary<string, List<User>> users = new Dictionary<string, List<User>>();

            users.Add("Members", new List<User>());
            users["Members"].Add(user);

            foreach (KeyValuePair<string, List<User>> userCategory in users)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n*** {userCategory} *******");
                Console.ForegroundColor = ConsoleColor.White;

                foreach (var individual in userCategory)
                {
                    Console.WriteLine(individual.Name);
                    Console.WriteLine(individual.City);
                    Console.WriteLine(individual.State);
                    Console.WriteLine(individual.Id);
                }
            }
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Id { get; set; }

        public User(string name, string city, string state, int id)
        {
            Console.WriteLine("User Created!");
        }
    }
}


```


**Expected Output:** 

```
User Created!

*** Members *******
John Doe
Winter Park
Florida
1234

```

<br>


## Topic: Read and Write Data
An application has more flexibility when it is able to both store and retrieve data. Using C# and the File, StreamReader, and StreamWriter classes gives us this ability. Any data read from a file can be stored for later use by using data structures. For example, a newly created User object (instance of the User class) may have a Name property. Data read from a file can be used to update the name value of that new instance.     
 

**1. From your research and use of the StreamReader class, respond to the following.**


- **A.** What namespace is used with the StreamReader class?: [ The namespace thats used at t![](he top is System.IO) ]
- **B.** Describe how you would check to see if a file has any additional lines to read when using the StreamReader class: [ i would read/display the lines from the file until i got to the end of it. I would also have to check and make sure the file isnt empty. i could use while((line=sr.Readline()) != null) ]  
- **C.** When creating a new StreamReader, what information is expected after the keyword "new"?
[ String path = "";
StreamReader sr = new streamReader(path);

string line;
while((line=sr.ReadLine()) != null)
{
Console.WriteLine(line);
}

sr.Close();
 ]


**2. Demonstrate how to use the StreamWriter class to write to a file. Include the following: A using statement, a StreamWriter object, and use of the File.AppendText() method. Explain each part of the code in your own words.**

```

[ using System;
using System.IO;

class Example
{
    public static void Main()
    {
        string path = @"c:\temp\MyTest.txt";
        // This text is added only once to the file.
        if (!File.Exists(path))
        {
            // This is just a simple file created so that we can add to it later
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }	
        }

        // This text will keep adding to the file until deleted. 
        using (StreamWriter sw = File.AppendText(path))
        {
            sw.WriteLine("This");
            sw.WriteLine("is Extra");
            sw.WriteLine("Text");
        }	

        // This is how you acces and open the file to see what was added.
        using (StreamReader sr = File.OpenText(path))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}]


```
    

**3. What is the difference between a property and an auto implemented property? When would you use one over the other..**

[ Simply put, the compiler creates the internal object and the accessors (get and set operations) for the auto-implemented properties so they’re mutable and after declaration the client code can change the values. This is an example of auto-implemented properties:

1
2
3
4
5
public class Population
{
    public int Male { get; set; }
    public int Female { get; set; }
}
By other hand, in properties the internal object and the accessors are up to you, so you need to write the necessary code as shown in the following example:

public class Population
{
    public int male;
    public int Male
    {
        get
        {
            return male;
        }
        set
        {
            male = value;
        }
    }
 
    public int female;
    public int Female
    {
        get
        {
            return female;
        }
        set
        {
            female = value;
        }
    }
}
Until this point, properties and auto-implemented properties seem identical in practical terms and in fact they’re in simple scenarios like previous but in complex classes that contain methods as well as significant logic, properties are the best option because you will be able to customize depending on your needs. Imagine you need a simple operation to get one of the values as follows:

public class Population
{
    public int Total { get; set; }
    public int Male { get; set; }
    public int Female {
        get
        {
            return Total - Male;
        }
    }
}
 ]



**4. If a class member contains the keyword "static", how do you use this outside of the defining class?. Provide an example with an explanation.**  


```

[ Class Program
{
//the members of the static class can be accessed directly using a class name
static void main(string[] args)
{
String stringName = ExampleClass.TheStaticMethod(paramaters);
}
}]


```

<br>

# Reference Links
Replace the example references and generic labels below with your own independent research. Do not use material already provided to you in this class. Two or more references are needed for each topic below.

**Working with Data**  
[https://jacace.wordpress.com/2012/05/27/differences-between-c-auto-implemented-properties-and-properties/](https://jacace.wordpress.com/2012/05/27/differences-between-c-auto-implemented-properties-and-properties/)  

[ This link helps explain the difference between auto-implemented properties and properties ]


[https://www.tutorialsteacher.com/csharp/csharp-static](https://www.tutorialsteacher.com/csharp/csharp-static)  

[ This link provides information on static classes and how to access them.]


**Read and Write Data**  
[https://www.youtube.com/watch?v=TElFkscb3bQ](https://www.youtube.com/watch?v=TElFkscb3bQ)

[ This resource helped me know more about streamreader and gave me examples to better understand. ]


[https://docs.microsoft.com/en-us/dotnet/api/system.io.file.appendtext?view=net-5.0](https://docs.microsoft.com/en-us/dotnet/api/system.io.file.appendtext?view=net-5.0)  

[ This help explain and give examples on how to write to the file ]






