# Algorithms-And-Complexity
# University of Lincoln


![University of Lincoln](http://thelincolnite.co.uk/wp-content/uploads/2012/07/new_uni_crest.jpg "University of Lincoln")


----------


This assignment asks you to design and implement a Search and Sort application. In particular, you
are to create a Console Application, which will help with the analysis of Weather Data. This
assignment has mandatory (1-4) and additional (5-9 and a couple more) tasks, which will allow you to
achieve higher marks.
A set of files is provided: “Year.txt”, “Month.txt”, “WS1_TMax.txt”, “WS1_TMin.txt”,
“WS1_AF.txt”, “WS1_Rain.txt”, “WS1_Sun.txt”, “WS2_TMax.txt”, “WS2_TMin.txt”,
“WS2_AF.txt”, “WS2_Rain.txt” and “WS2_Sun.txt”.
The files correspond to real averaged climate data of two Weather Stations WS1 (Lerwick), and WS2
(Ross on Wye) taken from the Met Office Historical Data web site. The “WS*_TMax.txt”,
“WS*_TMin.txt”, “WS*_AF.txt”, “WS*_Rain.txt” and “WS*_Sun.txt”, correspond to the Mean
Daily Temperature Maximum (in C), Mean Daily Temperature Minimum (in C), Days of Air Frost,
Total Rainfall (in mm) and Total Sunshine duration (in hours), respectively.
The values of all the files are currently sorted in ascended order (i.e. oldest to newest) in respect to the
content of the Year and Month files.
Initially, read the files “Year.txt”, “Month.txt”, “WS1_TMax.txt”, “WS1_TMin.txt”, “WS1_AF.txt”,
“WS1_Rain.txt” and “WS1_Sun.txt”.
Your Console Application should be able to provide the following functionality to the user:
1. Select which individual Array or String Array is to be analysed.
2. Sort in ascending or descending order and display the selected Array or String Array.
3. Search according to the content of the Year, and display ALL the corresponding values of
Year, Month, WS1_TMax, WS1_TMin, WS1_AF, WS1_Rain and WS1_Sun. If the value of 
the Year does not exist then provide an error message.
4. Search according to the content of the Month, and display ALL the corresponding values of
Year, Month, WS1_TMax, WS1_TMin, WS1_AF, WS1_Rain and WS1_Sun. If the value of
the Month does not exist then provide an error message.
5. When sorting in ascending or descending order the Month file you should display the months
as they appear during the calendar year (i.e. in ascending order they should be: January,
February, March, April, May, June, July, August, September, October, November and
December), not as they appear in alphabetical order (i.e. in ascending order they are: April,
August, December, February, January, July, June, March, May, November, October and
September).
6. Find the maximum and minimum values of WS1_TMax, WS1_TMin, WS1_AF, WS1_Rain
and WS1_Sun. You should then display ALL the corresponding values of Year, Month,
WS1_TMax, WS1_TMin, WS1_AF, WS1_Rain and WS1_Sun.
7. Repeat Task 6, but for the median values of WS1_TMax, WS1_TMin, WS1_AF, WS1_Rain
and WS1_Sun.
8. Your Console Application should be in position to rearrange and display the content of all the
other Arrays and String Arrays in respect to the one that is sorted.
9. For additional marks, your Console Application should be in position to input the files
“WS2_TMax.txt”, “WS2_TMin.txt”, “WS2_AF.txt”, “WS2_Rain.txt” and “WS2_Sun.txt”.
Then Repeat Tasks 1 to 8 and display the corresponding values for both WS1 and WS2.
