# Insertion Sort Assesment

## Question_1

[22,27,16,2,18,6] --> Steps of Insertion sort for this array

### Step_1

First item/number check step by step every single of item/number 

When the smallest item find replace with first item;

[2,27,16,22,18,6] --> Now first item is frozen

### Step_2

First step control logic will be applied next items;

[2,6,16,22,18,27] --> Now second item is frozen. This goes until last item 

.

.

.

.

[2,6,16,18,22,27] --> Sorting done. 

## Question_2

What is the Big-O notation?
n = array lenght 
Based on first question steps, control will be done like;
n + (n-1) + (n-2) + ......... + 1

n * (n + 1) / 2 --> (n^2 + n) / 2

O(n^2)

## Question_3

Time Complexity: After sorting of array , which one below case suits the number 18?

1. Average case: Number which we are looking for is the middle of the array  
2. Worst case: Number which we are looking for is the end of the array 
3. Best case: Number which we are looking for is the begining of the array 

Answer: 2-Worst case: Number which we are looking for is the end of the array 


## Question_4

[7,3,5,8,2,9,4,15,6] --> Write down first 4 steps of this array based on selection sort

### Step_1

First item/number check step by step every single of item/number 

When the smallest item find replace with first item;

[2,3,5,8,7,9,4,15,6] --> Now first item is frozen

### Step_2

First step control logic will be applied next items;

[2,3,5,8,7,9,4,15,6] --> Now second item is frozen. 


### Step_3

First item/number check step by step every single of item/number 

When the smallest item find replace with first item;

[2,3,4,8,7,9,5,15,6] --> Now third item is frozen

### Step_4

First step control logic will be applied next items;

[2,3,4,5,7,9,8,15,6] --> Now fourth item is frozen. This goes until last item 

