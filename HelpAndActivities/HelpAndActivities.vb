'Tim Rossiter
'RCET0265
'In class help and activities

Option Strict On
Option Explicit On
Option Compare Text


Imports System

Module HelpAndActivities
    Sub Main(args As String())
        Dim userQuits As Boolean = False
        Dim userInput As String 'contains the last user input string
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim isValidNumber As Boolean = False

        'loop until the user decides to quit
        Do Until userQuits = True

            'menu prompt
            'Console.Clear()
            Console.WriteLine("Make a selection. Press Q to quit.")
            Console.WriteLine("1. Add two numbers" & vbNewLine & "2. Reverse my text")
            'read user selection
            userInput = Console.ReadLine()


            'evaluate user selection
            Select Case userInput
                Case "Q"
                    userQuits = True
                Case "1"

                    Do
                        isValidNumber = False
                        Console.WriteLine("Please enter a number. Press Q to quit.")
                        userInput = Console.ReadLine()
                        Try
                            firstNumber = CInt(userInput)
                            isValidNumber = True
                        Catch ex As Exception
                            'decide what to do
                            If userInput = "Q" Then
                                userQuits = True
                            Else
                                Console.WriteLine($"Sorry, {userInput} is not a number
")
                            End If

                        End Try
                    Loop Until isValidNumber Or userQuits
                    isValidNumber = False

                    Do Until isValidNumber Or userQuits
                        isValidNumber = False
                        Console.WriteLine("Please enter a number. Press Q to quit.")
                        userInput = Console.ReadLine()
                        Try
                            secondNumber = CInt(userInput)
                            isValidNumber = True
                        Catch ex As Exception
                            'decide what to do
                            If userInput = "Q" Then
                                userQuits = True
                            Else
                                Console.WriteLine($"Sorry, {userInput} is not a number
")
                            End If

                        End Try
                    Loop

                    If userQuits = False Then
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
                    End If

                Case "2"
                    Console.WriteLine("you chose 2")
                Case Else
                    'invalid choice
                    Console.WriteLine("you chose poorly")
            End Select

        Loop

        Console.WriteLine("have a nice day!")
    End Sub
End Module
