   M S B A M L   `   `   `  ����  JSAM    JSAM.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  JSAM Software��5      $
��Auto��6   $
��Auto��6'   .��5	      �� $��5q�6   .@�5
      �� $��Information Center��6   $��22��6(   $��Bottom=�64   $��2,0,-6,0q�6O   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $ Vertical=�6   $
��Auto��6(   .+�5      �� $
��Jobs��6   $��Center=�6   $��5q�6:   �� 5      $��Job Name(Job ID)��6   $��8,0,0,0q�6)   �� 5      -   5        $��JobList��5      $
��Auto��6<   $��5q�6I   ��6   �� *Jobs+5      �� 5      $ Vertical=�6   $
��Auto��6)   $��5q�66   .+�5      �� $��Job Information��6   $��Center=�6)   $��5q�6F   �� 5      $ 
Horizontal=�6   $
��Auto��6,   $��5q�69   .+�5   	   �� $��Job #:��6   $��5q�6!   �� 5   	   $��5q�62   $
��Auto��6=   ��6   �� *CurrentJob.Id+6=   �� 5   	   $��Job Name��6   $	��0,5q�6#   �� 5   	   -   5        $	��Job��5      $��5q�6A   $
��Auto��6L   ��6   �� *CurrentJob.JobName+6L   5   	   �� 5      �� 5      $��Manpower Needs��6   $	��0,5q�6(   �� 5      $��	0,5,-59,5q�6<   $
��Left=�6O   $
��Auto��6j   ��6   �� *CurrentJob.ManpowerNeeds+6j   �� 5      $��Current Manpower��6   $	��0,5q�6*   �� 5      -   5        $��CurrentManpower��5      $	��0,5q�6*   5       5!      �� 5"      $ Vertical=�6   $
��Auto��6(   .+�5#      �� $��	Employees��6   $��Center=�6"   $��5q�6?   �� 5$      $��	Full Name��6   $��
8, 0, 0, 0q�6"   �� 5%      -   5         ��Name$ EmployeeList��5%      $
��Auto��6H   $��5q�6U   ��6&   �� *	Employees+6`   �� 5&      $ Vertical=�6   $
��Auto��6)   $��5q�66   .+�5(      �� $��Employee Information��6   $��Center=�6.   $��5q�6K   �� 5)      $ 
Horizontal=�6   $
��Auto��6,   $��5q�69   .+�5*   	   �� $��Employee #:��6   $��5q�6&   �� 5+   	   $��5q�67   $
��Auto��6B   ��6   �� *CurrentEmployee.Id+6B   �� 5,   	   $��
First Name��6   $	��0,5q�6%   �� 5-   	   -   5         ��Name$ First��5-      $��5q�6K   $
��Auto��6V   ��6    �� *CurrentEmployee.FirstName+6V   �� 5.   	   $��	Last name��6   $��5q�6$   �� 5/   	   -   5        $
 Last��5/      $��5q�6I   $
��Auto��6T   ��6   �� *CurrentEmployee.LastName+6T   50   	   �� 51      �� 53      $��Current Job (Name)��6   $	��0,5q�6,   �� 54      -   5        $ EmpCurrentJobName��54      $
��Auto��6+   $	��0,5q�68   $
��Left=�6E   �� 55      $��Current Job #��6   $	��0,5q�6'   �� 56      $ 
Horizontal=�6   .+�57   	   �� -   5        $ NewJobNumber��57      $
��Auto��6[   $��0,5,5,5q�6h   $
��Left=�6y   ��6'   �� *CurrentEmployee.JobId+ �� Mode$ OneWay=�6y   �� 58   	   -	   5         ��Name$ UpdateJobNumber��58      $��Update��6)   $��5q�6:   6E   59   	   �� 5:      �� 5<      $%��Employee Experience Information��6   $��Center=�69   �� 5=      $��Years of Service��6   �� 5>      -
   5        $ YearsOfService��5>      $
��Auto��6(   {�.  $
��Left=�6G   $	��0,5q�6b   �� 5?      $��Certifications��6   �� 5@      -   5         ��Name$ 	Certified��5@      $��Certified Electrician��6$   �� 5A      -   5        $ GeneratorTech��5A      $��Generator Certified��6(   �� 5B      -   5        $ Residential��5B      $��Residential��6&   �� 5C      -   5        $ Commercial_Industrial��5C      $��Commercial/Residential��60   5D      �� 5E      $ 
Horizontal=�6   .+�5F      �� -   5        $ 
RefreshEmp��5F      $��Refresh��6#   $��5q�65   �� 5G      -   5        $ ClearEmp��5G      $��Clear��6!   $��5q�61   5H      5I      5J      5K      5L      5M      