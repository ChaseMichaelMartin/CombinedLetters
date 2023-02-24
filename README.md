 Time Estimated : 2 hours 
 
 Actual Hours : 4 hours 



This project's purpose is to save on mailing fees. 

For example, if a student has both an admission letter and a scholarship letter, then we can combine the two letters, 
and mail them into one envelop thus saving postage. 

- This Console App has the following features:

1. Move all recieved files from the 'Input' folder to the 'Archive' folder.

2. Find out students who have recieved both admission & scholarship letters that day by using the Student's specific ID.
   Create/Save all combined letters to Output folder.
   
3. Generate a text report in specific formatting containing the processing date, the total number of combined letters & 
   their corresponding Uneversity IDs. This text report file is placed in the same folder as the combined letter as instructed.
   ('Output')


- How To Test/Verifiy:

1. Build Application

2. Press 'Start' button in IDE.

3. View the 'CombinedLetters.txt' folder to see each letter's content combined as one.

4. View the 'Report.txt' file in the 'Output' folder, NOTICE only two cobinedLetters & two unique IDs listed. 
   **(inputFile 5 and 6's student ID's don't match, therefore there is no student2 ( no 3rd student ID to list in Report.txt ))**
   
5. View the 'Archive' folder to view the 'Archive.txt' file containing all recieved file's content.


 Assumptions: 
  
  - I intitially attempted to use some old code I have from my college ConsoleApp projects. I tried using my StreamWriter code w/
  a list of letters collected from each department that combineTwoLetters() based on the conditions that would then generate a Student 
  Object. This Student would have a unique ID to list in the dated Report.txt & letter.Count() to tell if student has both a scholarship & admission form.
  
  
 Reason for not using interface & implementation class / Problems: 
 
 - I really wanted to use my StreamWriter code because I read you were allowed to use any string for inputFile content &
   there was no need to consider periperal requirements so I wanted to read  text and write text into certain directories,
   conditions & of course files.  
 
 - I tried to create a list by reading in files. I had two solutions I was tried to carry out. 
 
 - I was going to generate a Student if there was a duplicate of an ID string in list of Files.
 
 - I tried creating a list of students to take in letters if file IDs matched that would then be very easy to see if these student had two letters
   when decideing to generate a resultFile using CombinedLetters() etc. 
 
 - I tried creating a list of files that take in student field(s) &/or manipulate Student.letter .Counts() to verify.
 
 - I have used Arrays, Lists, HashMaps with db tabels, objects & in Unit Tests but not with txt or ConsoleApps. I bet if I had a little help this would've been a breeze! 
 
 
 Highlights: 
 
 - I just realized that there's probably a way to use the Archive folder to check whether or not the program was ran the previous day, I will try to create 
   a test tomorrow that checks for that while awaiting your reponse!  
 
 
 I would be more than happy to improve on this tomorrow. ( Friday, Feb. 24 )
 
 I am eager to hear back, thank you so much for your time!
  
  


