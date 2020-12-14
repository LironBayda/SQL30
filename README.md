# SQL30
SQL 30- answers

1. 
- Graphic User Interface is a form of User Interface that allows the user to interact with the software with Graphic means like icons.
- Business Logic is layer between the gui and the  DAL. It contain the logic of the project that manage the tables in the database. It contain SQL sentence.
- Data Access Layer- it contain the function that handle the SQL sentence. It interact directly with the database and create data for the BL.
2. it is best to perform the separation from the previous section because it is best to divide the code into separate layers. In this way we can implement separately each part and when we use one part, we don’t need to worry to the other parts
3. anonymous class it a class without a name. we don’t create a file to the class and we define it like this:
 // Anonymous type object 
        var anony_object = new {s_id = 134,  
                                s_name = "Siya",  
                             language = "Ruby"}; 
4. it is best practice to create anonymous object when preform SQL query because we use this object only in the method we create it and the use is simple and straightforward therefore it easier to use anonymous object and there is no need to create named class.
5. 1:1, 1:N, N:M (1:1 , 1:many , many:many)
6. we need to define Foreign Key (FK) references. Foreign Key (FK) need to be unique  And we must no t set the Foreign Key (FK) references to be NOT NULL
7. we use join query.
