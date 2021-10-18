# Instructions 
Update this document where indicated (brackets). Replace text inside the brackets with your own information. For example: Course Name should be the name of this course, and not the generic words "Course Name".

**Note:** As you complete each item, also update reference links where indicated below. 

<br>

## [ Application Developpmwnt Fundamentals] 

* **[ Version Control ]**
* **[ Bradley, Natasha ]**
* **[ 10/08/2021 ]**

This paper addresses some of the topic matter covered in research and activity this week. Be sure to include reference links below to the research and information you used to complete this assignment.

## Topic: Terminal
Professional developers use Terminal daily. It's essential to understand some fundamental commands to use the application. 

Update the information below to demonstrate your knowledge on this topic.   

**1. Using Terminal, there are essential commands to know.**

List the correct Terminal commands to do the actions listed below. Replace **CMD** with the correct command sequence. You can keep or enhance the brief description. 

**The last bullet provides an example**.

* [ cls ]: Clear the Screen 
* [ pwd ]: Print the "Working Directory"
* [ ls ]: List files and folders
* [ ls -a ]: List files and folders, including invisible files
* [ ls ]: List all files and folders, in human readable form
* [ cd ]: Change directory
* [ cd/ ]: Change directory, go to root directory
* [ cd ]: Change directory and go to user home directory
* [ cd .. ]: Change directory, go up one folder level
* [ cd ../../ ]: Change directory, go up two folder levels
* **cd ~/Desktop/**: Change directory to my desktop! 


**2. Using Terminal...**

**Folder Drop:** Try typing "cd" followed by a space, and then drag a folder into terminal and press return. Test this out and describe your results below.  

[ To me not much happened. However it did show me the path to that file. ]


## Topic: Version Control & Git
Version control, also known as revision control, records changes to a file or set of files over time so that you can recall specific versions later. In this class, we are learning Git. Update the information below where indicated.  

**1. There are three types of version control. List and describe each.**

[Local Version Control System -A local version control system is a file located on your local computer, in which every file change is stored as a patch

Centralized Version Control System-A centralized version control system has a single server that contains all the file versions.

Distributed Version Control- With distributed version control systems, clients don’t just check out the latest snapshot of the files from the server, they fully mirror the repository, including its full history.]




**2. Using Terminal, there are also essential Git commands to know.**

List the correct Git commands to do the actions listed below in Terminal. Replace CMD with the correct command and keep or enhance the brief description. **The last bullet provides an example**. 

* [ git-clone ]: Clone a repository
* [ git config --global user.name “” ]: Set-up a global user name
* [ git config --global user.email “” ]: Set-up a global email address (to match my GitHub account eMail)
* git status : [ displays the state of the working directory ]
* [ git add  ]: Add modified files to the next commit
* [ git commit ]: Make a commit with a new message
* [ git log ]: Show my commit history
* **git help**: This command will bring up Git's help screen in Terminal!
    



**3. Connecting to GitHub using Terminal.**
HTTPS is the the correct way to connect to GitHub in this course. Describe how you connect to GitHub from Terminal using this protocol. What steps do you take? 

[Clone down the repository to your desktop (whatever preferred location) and then with the terminal use git.add to add the changes, the git.commit to commit why/what i changed anf finally git.push to push it to the online version. ]



**4. Using .gitignore and Why it's Important**  
Most repositories contain a .gitignore file. 

* What is the purpose of this file?  
* What is the "**.DS_Store**" file and why would you want to ignore it?
* What other file or folder would you want to add to a .gitignore file and why? 


[-The . gitignore file tells Git which files to ignore when committing your project to the GitHub repository. 

-If you are using macOS, your system appends the . DS_Store file in your directories. It's not a big issue, but often you need to exclude these files explicitly in your . gitignore file, to prevent any unnecessary files in your commit

-Generated files like dist folders. Just because these do not need to be tracked.]



<br>

# Reference Links
Replace the example references below with your own links and recommended resources, including the generic "Site Address" label. It is acceptable to provide multiple links for a single topic and to use material provided to you in this class. You are encouraged to link to your own independent research as well. 

[ Research Summary: For me the most useful bit of information was the website that provided me with what the three types of version control are. I had trouble understanding them at first and this helped clairify them. ]

**Terminal Commands**  
[https://learnpythonthehardway.org/book/appendixa.html](https://learnpythonthehardway.org/book/appendixa.html)  

**Three Types of Version Control**  
[https://blog.eduonix.com/software-development/learn-three-types-version-control-systems/](https://blog.eduonix.com/software-development/learn-three-types-version-control-systems/)

**Git Commands**  
[https://education.github.com/git-cheat-sheet-education.pdf](https://education.github.com/git-cheat-sheet-education.pdf)

**Connecting to GitHub using Terminal**  
[https://docs.github.com/en/get-started/quickstart/set-up-git](https://docs.github.com/en/get-started/quickstart/set-up-git)

**Using .gitignore and Why it's Important**  
[https://www.bmc.com/blogs/gitignore/#](https://www.bmc.com/blogs/gitignore/#)

[https://pineco.de/snippets/globally-gitignore-the-ds_store-file/](https://pineco.de/snippets/globally-gitignore-the-ds_store-file/)





