   M S B A M L   `   `   `  ���� ?  ;JSAM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:JSAMJSAM  7 clr-namespace:JSAM.BusinessLogicJSAM.BusinessLogic      JSAM.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $localclr-namespace:JSAM     :BusinessLogic clr-namespace:JSAM.BusinessLogic       � Title$  JSAM Software��$
��Auto��$
��Auto��.���� $��5q�.@��� $
��Jobs��.����  �� Orientation$ 
Horizontal=�.+��� $ Vertical=�.+��� $��Job List��$��5q��� -   $��JobList��$	��390��$��5q����� *Jobs+�� $ Vertical=�$
��Auto��$��5q�.+��� $��Job Information��$��Center=�$��5q��� $ 
Horizontal=�$
��Auto��$��5q�.+��� $��Job #:��$��5q��� $��5q�$��75������ *CurrentJob.Id+�� $��Job Name��$	��0,5q��� -   $	��Job��$��5q�$��75������ *CurrentJob.JobName+�� �� $��Manpower Needs��$	��0,5q��� $	��350��$	��0,5q�$
��Left=����� *CurrentJob.ManpowerNeeds+�� $��Current Manpower��$	��0,5q��� -   $��CurrentManpower��$	��0,5q��� $��	Employees��.���� $ 
Horizontal=�.+��� $ Vertical=�$
��Auto��$��5q�.+��� $��Employee List��$��Center=��� -   $��EmployeeList��$	��390��$��5q����� *	Employees+�� $ Vertical=�$
��Auto��$��5q�.+��� $��Employee Information��$��Center=�$��5q��� $ 
Horizontal=�$
��Auto��$��5q�.+��� $��Employee #:��$��5q��� $��5q�$��75������ *CurrentEmployee.Id+�� $��
First Name��$	��0,5q��� -   $��First��$��5q�$��75������ *CurrentEmployee.FirstName+�� $��	Last name��$��5q��� -   $
��Last��$��5q�$��75������ *CurrentEmployee.LastName+�� �� $��Current Job (Name)��$	��0,5q��� -   $��EmpCurrentJobName��$	��350��$	��0,5q�$
��Left=��� $��Current Job #��$	��0,5q��� $ 
Horizontal=�.+��� -   $��NewJobNumber��$��65��$��0,5,5,5q�$
��Left=����� *CurrentEmployee.CurrentJob+�� -	   $��UpdateJobNumber��$��Update��$��5q��� �� $%��Employee Experience Information��$��Center=��� $��Years of Service���� -
   $��YearsOfService��$��65��{�.  $
��Left=�$	��0,5q��� $��Certifications���� -   $��	Certified��$��Certified Electrician���� -   $��GeneratorTech��$��Generator Certified���� -   $��Residential��$��Residential���� -   $��Commercial_Industrial��$��Commercial/Residential���� $ 
Horizontal=�.+��� -   $��
RefreshEmp��$��Refresh��$��5q��� -   $��ClearEmp��$��Clear��$��5q�