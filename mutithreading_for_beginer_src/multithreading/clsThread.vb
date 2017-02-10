Imports System.Threading

Public Class clsThread
    'This variable will hold the Thread Index that are passed from the main window, when we created it
    Private m_ThreadIndex As Integer

    'This is local thread variable. We will send the value of this variable to the parent form
    Private m_Counter As Integer = 0

    'We will need this variable to pass argument to the method of the main window
    Private m_Args(1) As Object

    'This will hold the ref to the main window,
    Private m_MainWindow As Form

    'We have to create a delegate to call the Notification Method on the main form (ReceiveThreadMessage())
    'Delete is nothing, but a Type Safe Pointer. It works same way like Callback function in C++/VC++
    'If you like to know more about delegates plz visit http://www.15seconds.com/issue/020815.htm
    'This delete sub should have same signature (declaration) as the method, that are there in the main from.
    'Which we will call from this thread. 

    'Here we are going to call the method ReceiveThreadMessage() of the main form. 
    'So the declaration of the delete should be same as ReceiveThreadMessage()

    Private Delegate Sub NotifyMainWindow(ByVal ThreadIndex As Integer, ByVal Counter As Integer)
    'We need an object of this deletegate
    Private m_NotifyMainWindow As NotifyMainWindow

    Public Sub New(ByVal ThreadIndex As Integer, ByRef MainWindow As frmMain)
        m_ThreadIndex = ThreadIndex
        m_MainWindow = MainWindow

        'We need to point our delegate to the Method, which we want to call from this thread
        m_NotifyMainWindow = AddressOf MainWindow.ReceiveThreadMessage
    End Sub

    Public Sub StartThread()
        While True
            m_Counter = m_Counter + 1

            'we need to create this array such a way, that it should contains the no of elements, that we need
            'to pass as the arguments.
            'Here we will pass two arguments ThreadIndex and Counter, so we took the array with 2 elements.
            'Now we need to place the variable to the appropriate position of this array.
            'Like : Our First Argument is ThreadIndex, so we will put ThreadIndex into the first element and 
            'm_counter into the second element.
            'Basically you have to put the variables into the array with the same sequence that is there in the
            'argument list
            ReDim m_Args(1)
            m_Args(0) = m_ThreadIndex
            m_Args(1) = m_Counter

            'Call the notificaiton method on the main window by the delegate
            m_MainWindow.Invoke(m_NotifyMainWindow, m_Args)

            'wait for some time before continuing loop
            Thread.Sleep(1000)
        End While
    End Sub
End Class
