   M S B A M L   `   `   `  ����X  TWpfAppGestionGarageManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:WpfAppGestionGarageManagementWpfAppGestionGarageManagement  5   	   .    (WpfAppGestionGarageManagement.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:WpfAppGestionGarageManagement     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   ���	#FFE89595.��5	      � .+�5
   
   �� -   5        $��Ajouter��5
      $
��Left=�6#   $��
51,290,0,0q�6>   $	��Top=�5      $	��145��6)   $��37��65   6A   �� 5   
   -   5         ��Name$ LBGarage��5      $��Center=�6$   $��30��6A   $��Gestion Garage��6M   $	��Top=�6c   $	��792��6{   ���	#FFF7E5E5 �� TextAlignment$ Center=�6�   $��Times New Roman)�6�   $��16(�6�   �� 5   
   $��Marque��6   $
��Left=�6!   $��38��6<   $��	22,52,0,0q�6H   $	��Top=�6[   $	��110��6s   �� 5   
   $��	Matricule��6   $
��Left=�6$   $��38��6?   $��	22,90,0,0q�6K   $	��Top=�6^   $	��110��6v   �� 5   
   $��NumeroChassis��6   $
��Left=�6(   $��38��6C   $��
22,128,0,0q�6O   $	��Top=�6c   $	��110��6{   �� 5   
   $	��Nom��6   $
��Left=�6   $��38��69   $��
22,166,0,0q�6E   $	��Top=�6Y   $	��110��6q   �� 5   
   $��Photo��6   $
��Left=�6    $��38��6;   $��
338,56,0,0q�6G   $	��Top=�6[   $	��110��6s   �� 5   
   -   5        $ 	txtMarque��5      $
��Left=�6%   $��22��6@   $��
148,52,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��138��6�   �� 5   
   -   5        $ txtMatricule��5      $
��Left=�6(   $��22��6C   $��
148,90,0,0q�6O   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��138��6�   �� 5   
   -   5        $ txtNumeroChassis��5      $
��Left=�6-   $��22��6H   $��148,128,0,0q�6T   $
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��138��6�   �� 5   
   -   5        $ txtNom��5      $
��Left=�6#   $��22��6>   $��148,164,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��138��6�    J� RenderTransformOrigin$ 0.667,0.409&�6�   �� 5   
   -   5         ��Name$ imgPhoto��5      $
��Left=�6"   $	��148��6=   $��
482,56,0,0q�6J   $	��Top=�6^   $	��266��6v   $��/images/Citroen.jpg��6�   $
��Fill=�6�   �� 5   
   $
��Left=�69   $��62��6T   $��
34,347,0,0q�6`   $	��Top=�6t   $	��748��6�   ��6   ��  �� Path$ Voitures� �� View 5      �� 5      .P�5      ��  �� DisplayMemberBinding 6%   �� *Marque+5      5      5      5       