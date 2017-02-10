Imports System.Threading


Public Class frmMain
    Public m_ThreadList As New ArrayList

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Check if the 1st element of the arraylist (m_ThreadList) contains any thread object
        If Not m_ThreadList(0) Is Nothing Then
            'If the 1st element contains any thread object. Then check its status. If its running (IsAlive) then no need start it again
            If CType(m_ThreadList(0), Thread).IsAlive Then
                MsgBox("You can not start this thread again. Becoz this thread is still alive !!", MsgBoxStyle.Critical)
            Else
                'Thread object is there but thread is not active. Its dead !! You can create new again
                GoTo StartThread
            End If
        Else
            'No thread object is there in 1st element of our thread list. You can create new 
            GoTo StartThread
        End If
        Exit Sub
StartThread:
        'Create a object of our Thread Class (clsThread). The new thread will work with this object.
        'You can assume that this object will become a thread. Though it's not, But it will ease your understanding

        'When creating the object we can pass arguments to the constructer (New method) of the class for the new thread.
        'Thus when the thread will run independently, it will have these variables.

        'We will pass a integer as a thread index. So when this thread will send message to our main window (this form),
        'We will pass the index from the thread to this from, and we will be able to recognize the thread by the index.
        'We will be able to know, from which thread the message is comming.
        'Also we will pass a ref to this form to the thread, that the tread can communicate with this form
        Dim objThreadClass As New clsThread(1, Me)

        'Now we will create a Thread Object. When we create a thread object, we need to specify a start point of the thread.
        'This start point is basically a Method of the Object, that we have just made. 
        'When we will ask the thread to start. It will execute the specified method of the object
        Dim objNewThread As New Thread(AddressOf objThreadClass.StartThread)

        'Here we will make the IsBackgound property of the thread as True, thus if your main application terminates,
        'all the thread associated with the main programe (ProcessID) will be terminated too.
        'Read the following comments from MSDN.

        'A thread is either a background thread or a foreground thread. 
        'Background threads are identical to foreground threads, 
        'except that background threads do not prevent a process from terminating. 
        'Once all foreground threads belonging to a process have terminated, 
        'the common language runtime ends the process. 
        'Any remaining background threads are stopped and do not complete.
        objNewThread.IsBackground = True

        'Now we will ask our thread to start, which will basically fire the method of our thread class, 
        'that we have specifed as the start point (the method StartThread())
        objNewThread.Start()

        'Now we will add this thread object to our thread list (m_ThreadList). Becoz we will need this object
        'to terminate or suspend the tread. Without referance to this object, the tread can't be handled
        m_ThreadList.Item(0) = objNewThread

        'We are dealing with 4 fixed thread. If you want to deal with unknown numbers of threads
        'Simply add each tread object to the arraylist and pass the last index of the array list as the thread index

        'The code will be changed like following

        'Dim objThreadClass As New clsThread(m_ThreadList.count, Me)
        'm_ThreadList.add(objNewThread)

        'This way, when u will get message from thread, you have to deal with appropriate elemtn in this arraylist
        'You will get back the index from thread
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Not m_ThreadList(1) Is Nothing Then
            If CType(m_ThreadList(1), Thread).IsAlive Then
                MsgBox("You can not start this thread again. Becoz this thread is still alive !!", MsgBoxStyle.Critical)
            Else
                GoTo StartThread
            End If
        Else
            GoTo StartThread
        End If
        Exit Sub
StartThread:
        'This our second thrread, So we will Pass '2' as the tread index
        Dim objThreadClass As New clsThread(2, Me)
        Dim objNewThread As New Thread(AddressOf objThreadClass.StartThread)
        objNewThread.IsBackground = True
        objNewThread.Start()
        m_ThreadList.Item(1) = objNewThread
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Not m_ThreadList(1) Is Nothing Then
            If CType(m_ThreadList(1), Thread).IsAlive Then
                MsgBox("You can not start this thread again. Becoz this thread is still alive !!", MsgBoxStyle.Critical)
            Else
                GoTo StartThread
            End If
        Else
            GoTo StartThread
        End If
        Exit Sub
StartThread:
        'This our third thrread, So we will Pass '3' as the tread index
        Dim objThreadClass As New clsThread(3, Me)
        Dim objNewThread As New Thread(AddressOf objThreadClass.StartThread)
        objNewThread.IsBackground = True
        objNewThread.Start()
        m_ThreadList.Item(2) = objNewThread
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Not m_ThreadList(1) Is Nothing Then
            If CType(m_ThreadList(1), Thread).IsAlive Then
                MsgBox("You can not start this thread again. Becoz this thread is still alive !!", MsgBoxStyle.Critical)
            Else
                GoTo StartThread
            End If
        Else
            GoTo StartThread
        End If
        Exit Sub
StartThread:
        'This our forth thrread, So we will Pass '4' as the tread index
        Dim objThreadClass As New clsThread(4, Me)
        Dim objNewThread As New Thread(AddressOf objThreadClass.StartThread)
        objNewThread.IsBackground = True
        objNewThread.Start()
        m_ThreadList.Item(3) = objNewThread
    End Sub


    'This the method which will accept message from thread, you can not access any control of the form, directly
    'from the thread. Instead, you need to pass some value from the tread to the form and according to those values
    'you have to take appropriate action on the form.
    'This method should be Public. Otherwise from the thread, u will not be able to invoke it
    Public Sub ReceiveThreadMessage(ByVal ThreadIndex As Integer, ByVal Counter As Integer)
        'The arguments ThreadIndex and Counter will be recieved from the thread. The thread will pass these arguments, 
        'While invoking this method

        'Now first of all we will check from which thread we are getting message, its indicated by the argument ThreadIndex
        'According to this value we will look into our ThreadList (m_ThreadList).
        'We can access the corresponding thread object by m_ThreadList(ThreadIndex-1)
        'Here we have -1 becoz we have thread index from 1 but start index of arraylist is 0.
        'So position of the thread object in arraylist is ThreadIndex-1.

        'We will show the counter to the appropriate label on the form. There are 4 counter.
        'We will show according to, from which thread we are getting message

        'We will also check if we checked the checkbox to stop the thread on a particular value of counter
        Select Case ThreadIndex
            Case 1
                Me.lbl_ThreadCounter1.Text = Counter.ToString
                If Me.chk_Thread1.Checked Then
                    'If the appropriate check box is checked we will look into the stop counter
                    If Counter = Convert.ToInt32(Me.txt_ThreadStopCounter1.Text) Then
                        'if it matched with counter variable, passed from the tread, we will stop that thread.
                        CType(m_ThreadList(ThreadIndex - 1), Thread).Abort()
                        'Remove the object from the thread list
                        m_ThreadList(ThreadIndex - 1) = Nothing
                    End If
                End If
            Case 2
                Me.lbl_ThreadCounter2.Text = Counter.ToString
                If Me.chk_Thread2.Checked Then
                    If Counter = Convert.ToInt32(Me.txt_ThreadStopCounter2.Text) Then
                        CType(m_ThreadList(ThreadIndex - 1), Thread).Abort()
                        m_ThreadList(ThreadIndex - 1) = Nothing
                    End If
                End If
            Case 3
                Me.lbl_ThreadCounter3.Text = Counter.ToString
                If Me.chk_Thread3.Checked Then
                    If Counter = Convert.ToInt32(Me.txt_ThreadStopCounter3.Text) Then
                        CType(m_ThreadList(ThreadIndex - 1), Thread).Abort()
                        m_ThreadList(ThreadIndex - 1) = Nothing
                    End If
                End If
            Case 4
                Me.lbl_ThreadCounter4.Text = Counter.ToString
                If Me.chk_Thread4.Checked Then
                    If Counter = Convert.ToInt32(Me.txt_ThreadStopCounter4.Text) Then
                        CType(m_ThreadList(ThreadIndex - 1), Thread).Abort()
                        m_ThreadList(ThreadIndex - 1) = Nothing
                    End If
                End If
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'We will first check our Thread List if the Thread Object is there.
        'If it there, then we will see its status.
        'If its status is Alive or Active we will kill the thread.
        If Not m_ThreadList(0) Is Nothing Then
            If CType(m_ThreadList(0), Thread).IsAlive Then
                CType(m_ThreadList(0), Thread).Abort()
                m_ThreadList(0) = Nothing
                Me.lbl_ThreadCounter1.Text = "0"
            Else
                MsgBox("No thread is active in this section", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("No thread is active in this section", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Not m_ThreadList(1) Is Nothing Then
            If CType(m_ThreadList(1), Thread).IsAlive Then
                CType(m_ThreadList(1), Thread).Abort()
                m_ThreadList(1) = Nothing
                Me.lbl_ThreadCounter2.Text = "0"
            Else
                MsgBox("No thread is active in this section", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("No thread is active in this section", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Not m_ThreadList(2) Is Nothing Then
            If CType(m_ThreadList(2), Thread).IsAlive Then
                CType(m_ThreadList(2), Thread).Abort()
                m_ThreadList(2) = Nothing
                Me.lbl_ThreadCounter3.Text = "0"
            Else
                MsgBox("No thread is active in this section", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("No thread is active in this section", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Not m_ThreadList(3) Is Nothing Then
            If CType(m_ThreadList(3), Thread).IsAlive Then
                CType(m_ThreadList(3), Thread).Abort()
                m_ThreadList(3) = Nothing
                Me.lbl_ThreadCounter4.Text = "0"
            Else
                MsgBox("No thread is active in this section", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("No thread is active in this section", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        m_ThreadList.Add(Nothing)
        m_ThreadList.Add(Nothing)
        m_ThreadList.Add(Nothing)
        m_ThreadList.Add(Nothing)
    End Sub
End Class
