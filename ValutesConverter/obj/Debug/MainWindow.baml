   M S B A M L   `   `   `  ����K  GValutesConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ValutesConverterValutesConverter  5   	   !    ValutesConverter.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ValutesConverter     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ CurrenciesListBox��5
      $
��Left=�6.   $	��212��6I   $��	22,29,0,0q�6V   $	��Top=�6i   $	��182��6�   �� 5   
   -   5         ��Name$ Course��5      $��Курc:��6    $
��Left=�60   $��
221,45,0,0q�6K   $	��Top=�6_   $��63��6w   $��26��6�   �� 5   
   -   5         ��Name$ SelectedCurrencieValue��5      $
��Left=�6{   $��
299,50,0,0q�6�   $
��Wrap=�6�   $	��Top=�6�   $	��111��6�   ��64   ��  �� ElementName$ CurrenciesListBox�� �� Path$ SelectedItem.Rate�6�   �� 5   
   $6��0Введите количество валюты��6   $
��Left=�64   $��235,131,0,0q�6O   $	��Top=�6d   $	��175��6|   �� 5   
   -   5         ��Name$ InputTextBox��5      $
��Left=�6(   $��23��6C   $��235,183,0,0q�6O    �� TextWrapping$
 Wrap=�6d   $	��Top=�6y   $	��175��6�   �� 5   
   -   5         ��Name$ CalculateButton��5      $��Поcчитать��6I   $
��Left=�6]   $��235,211,0,0q�6x   $	��Top=�6�   $	��175��6�   	 J� RenderTransformOrigin$	 
0.44,0.517&�6�   �� 5   
   -   5        $ ResultTextBlock��5      $
��Left=�6-   $��235,236,0,0q�6H   $
��Wrap=�6]   $	��Top=�6q   $	��175��6�   5      5      