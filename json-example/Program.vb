
Imports System.Collections.Generic
Imports Newtonsoft.Json
Namespace JsonExample
    Module Program
        Sub Main()
            ' Create an empty list to hold all our test data.  
            ' This list specifically holds only items that have a type of Test.  
            ' You can't put anything else in this list.  No strings or ints or decimals, only Test.
            Dim tests As New List(Of Test)()


            ' Here is some example data. You might get these values from textboxes on a form in your program. 
            Dim name As String = "Nick"
            Dim points As Integer = 100
            Dim description As String = "Some cool guy"
            Dim somethingElse As Decimal = 1.02D


            ' Using the values from above, create an instance of the Test class.  
            ' It's definition is in Test.cs
            Dim firstTest As New Test(name, points, description, somethingElse)


            ' Lets make some more.
            Dim name2 As String = "Brian"
            Dim points2 As Integer = 50
            Dim description2 As String = "not as cool as Nick."
            Dim somethingElse2 As Decimal = 4D


            ' create another instance of Test using the new set of data.
            Dim secondTest As New Test(name2, points2, description2, somethingElse2)


            ' Add the two tests to our list.
            tests.Add(firstTest)
            tests.Add(secondTest)


            ' Take our list and convert it to json, which is some fancy javascript text format very common in the industry.
            Dim json As String = JsonConvert.SerializeObject(tests, Formatting.Indented)

            Console.WriteLine(json)

            ' If you look at the value of the json variable above, it will look like this.
            '
            '                "[
            '                    {
            '                        "Name":"Nick",
            '                        "Points":100,
            '                        "Description":"Some cool guy",
            '                        "SomethingElse":1.02
            '                    },
            '                    {
            '                        "Name":"Brian",
            '                        "Points":50,
            '                        "Description":"Not as cool as Nick.",
            '                        "SomethingElse":4.00
            '                    }
            '                ]"
            '            


            ' The square brackets indicate a list, the curly brackets indicate an object. Inside that, everything is key value pairs.  
            ' A value could also be another list or another object.
            ' If you wanna know more about json, google it.

            ' Save the json to a file.
            System.IO.File.WriteAllText("./data.json", json)
            Console.WriteLine("File saved.")
            ' To see the file go to bin/Debug/data.json
            Console.WriteLine("To see the file, go to your project folder and then to bin/Debug/data.json")
            Console.ReadLine()
        End Sub
    End Module

End Namespace