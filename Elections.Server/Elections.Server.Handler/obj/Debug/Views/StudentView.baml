   M S B A M L   `   `   `  ����  Elections.Server.Handler0    *Elections.Server.Handler.Views.StudentView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      X TXceed.Wpf.Toolkit, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      ^ ZCaliburn.Micro.Platform, Version=3.0.1.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21f(calhttp://www.caliburnproject.org  5      $	��416��5      $	��268��6   .��5	      �� 
���   �$��1q�6!   ._�5   
   � -   5          �Name$  ContentGrid��5      $
��Left=�6$   $	��416��6?   $	��Top=�6L   $	��268��6d   .+�5      �� $
��Left=�6   $��26��60   $��	10,10,0,0q�6<   $	��Top=�6O   $	��248��6g   ._�5      (  "Xceed.Wpf.Toolkit.WatermarkTextBox  -   5        $��Number��5   (      	Watermark$ Ingrese Número...��66   
�����F�$��0,0,0,1q�6l   ��6�   �� *Number+5      �� 5      $
��Left=�6   $��26��60   $��	10,46,0,0q�6<   $	��Top=�6O   $	��248��6g   ._�5        $ Ingrese Identidad...��6(   
�����F�$��0,0,0,1q�6a   ��6{   �� *	FirstName+5      �� 5      $
��Left=�6   $��26��60   $��	10,82,0,0q�6<   $	��Top=�6O   $	��248��6g   ._�5        $ Ingrese Primer Nombre...��6(   
�����F�$��0,0,0,1q�6e   5      �� 5      $
��Left=�6   $��26��60   $��
10,118,0,0q�6<   $	��Top=�6P   $	��248��6h   ._�5        $ Ingrese Segundo Nombre...��6(   
�����F�$��0,0,0,1q�6g   5      �� 5      $
��Left=�6   $��26��60   $��
10,154,0,0q�6<   $	��Top=�6P   $	��248��6h   ._�5        $  Ingrese Primer Apellido...��6(   
�����F�$��0,0,0,1q�6h   5      �� 5       $
��Left=�6   $��26��60   $��
10,190,0,0q�6<   $	��Top=�6P   $	��248��6h   ._�5!        $! Ingrese Segundo Apellido...��6(   
�����F�$��0,0,0,1q�6h   5"      �� 5$      $
��Left=�6   $��26��60   $��
10,226,0,0q�6<   $	��Top=�6P   $	��248��6h   ._�5%      )  #Xceed.Wpf.Toolkit.WatermarkComboBox     	Watermark$ Sexo...��6)   
�����F�$��1,1,1,1q�6U   5&      �� 5(      $
��Left=�6   $��26��60   $��
10,262,0,0q�6<   $	��Top=�6P   $	��248��6h   ._�5)        $ Grado...��6)   
�����F�$��1,1,1,1q�6V   5*      �� 5,      $
��Left=�6   $��26��60   $��
10,298,0,0q�6<   $	��Top=�6P   $	��248��6h   ._�5-        $ Sección...��6)   
�����F�$��1,1,1,1q�6X   5.      �� 50      $��Guardar��6   $
��Left=�6'   $��
10,344,0,0q�6B   $	��Top=�6V   $	��248��6n   $��26��6z   .  (System.Windows.Interactivity.Interaction   Triggers 51      /  )System.Windows.Interactivity.EventTrigger  52         	EventName$ Click��6%   .  (System.Windows.Interactivity.TriggerBase   Actions. 53      "  Caliburn.Micro.ActionMessage     
MethodName$
 Save��6,      
Parameters. 54        Caliburn.Micro.Parameter     Value 6,   �� 	 �� ElementName$	 ContentGrid��55      56      58      �� 59      -   5        
 ��Name$
 Cancel��59      $��Cancelar��6%   $
��Left=�68   $��
10,380,0,0q�6S   $	��Top=�6g   $	��248��6   $��26��6�   5:      5;      5>      