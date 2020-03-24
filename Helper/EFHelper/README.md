# EFHelper version 1.0.0

## Minimum Requirement For Installation  
   1. TargetFramework netcoreapp 2.1 </br>
   2. Microsoft.CodeAnalysis 3.4.0 </br>
   3. Microsoft.EntityFrameworkCore 2.1.8 </br>
   4. Microsoft.EntityFrameworkCore.Relational 2.1.8 </br>
   5. System.Data.SqlClient 4.8.0 </br>
   
## Note
	1. Problem with boolean datatype , cannot determine is it null or not?
	2. Please convert bool data type tp char(1) data type, the value between 0,1. 0 means false 1 means true
	3. Solved, booleadn can be used again... but you must add nulable.. so become nullable<boolean>
## Project structures in Database context
   1. The folder must Folder => File, Folder refers to schema name, File refers to table name
      ex: user/mtEmployee.cs, user is the schema, mtEmployee.cs is table name

## How To Use
   1. Instance your DatabaseContext ,ex: var myUserDBContext = new UserDBContext(). </br>
      if you want specific connection timeout, please set in your DBContext</br>
   2. Create Instance class of RepoWrapper or  RepoWrapperAsync </br>
      var repoWrapper =  new RepoWrapper(myUserDBContext) </br>
      if make call instance new RepoWrapper(), you must call SetConnectionContext(DbContext dbContext) </br>
   3. Call your Desired methods

## Return Value
   1. This EFHelper has same return value,it's' EFReturnValue
   2. IsSuccessConnection,true =>  Ok connection to database, false =>failed connection to database
   3. IsSuccessQuery, true => Pk excecutionQuery,false => failed execution query
   4. ErrorMessage, if(IsSuccessConnection & IsSuccessQuery) will return empty else will write a message
   5. ReturnValue,it's' dynamic class, can be anything, usually T or List<T>, it's' depends on parameters
      ,if the parameter is T1,T2 or int1,int2, etc will return T1,T2(Dictionary Type)
	  ex: Dictionary:name entity1, object objEntity1     
	  ,if the parameter is List<T1>,List<T2> or List<int1>,List<int2> will return List<T1>,List<T2>(Dictionary Type)
	  ex: Dictionary:name entity1, object List<objEntity1>   
   6. OK result, make sure the IsSuccessConnection = true and IsSuccessQuery = true
   7. Failed result, if one of IsSuccessConnection and IsSuccessQuery is false
   8. How to retrieve data ReturnValue.ReturnValue in List<T>
      var myList = list.ListData<T>(param);
	  var myListData =(List<T>)myList.ReturnValue[0].ReturnValue;
	  Index[0] depends on the order of T Class, T,T1,T2,T3,T4,T5,etc , will give order [0][1][2][3][4][5] 
   9. Happy coding

## List Of available methods (synchronous)
   1. Save, save data to database
   2. SaveList, save list data to databas
   3. SaveHeaderDetail , save data Table header and table Details
   4. Update, update data to database, only not null columns will updated
   5. UpdateAll, update data to database, all columns will updated
   6. UpdateList,update list data to database, only not null columns will updated
   7. UpdateAllList, update list data to database, all columns will updated
   8. SaveUpdate ,save or update data to database
   9. SaveUpdateList ,save or update list data to database
   10. Delete, delete physically data from database
   11. DeleteList, delete physically list data from database
   12. DeleteActiveBool,for soft delete data, must exist boolean tablefield Activebool ot boolactive in your table,
	  not delete physically, only update to false
   13. DeleteActiveBoolList, for soft delete list data, must exist boolean tablefield Activebool ot boolactive in your table,
	   not delete physically, only update to false
   14. DeleteHeaderDetail, delete data header detail physically (soft delete)
   15. DeleteHeaderDetailList, delete list data header detail not physically (soft delete)
   16. DeleteHeaderDetailActiveBool, delete data header detail not physically (soft delete)
   17. DeleteHeaderDetailActiveBoolList, delete data header detail not physically (soft delete)
   18. ListData, make query list to database
   19. ListDataQueryable, make query list to database, Iqueryable is from RepoWrapper Context
   20. DeleteSave, Delete physically data based on parameter, and save data
   21. DeleteSaveList, Delete physically data based on parameter, and save list data
   20. DeleteSaveActiveBool, soft delete data based on parameter, and save data
   21. DeleteSaveActiveBoolList, soft delete data based on parameter, and save list data
   22. SaveUpdateDelete, Save or update or delete data from/to database
   23. SaveUpdateDeleteList, Save or update or delete list data from/to database
   24. SaveUpdateDeleteActiveBool, Save or update or delete data softly from/to database
   25. SaveUpdateDeleteActiveBoolList, Save or update or delete list data softly from/to database

## List Of available methods (Asynchronous), you must use await for these methods
   1. SaveAsync, save data to database
   2. SaveListAsync, save list data to databas
   3. SaveHeaderDetailAsync, save data Table header and table Details
   4. UpdateAsync, update data to database, only not null columns will updated
   5. UpdateAllAsync, update data to database, all columns will updated
   6. UpdateListAsync,update list data to database, only not null columns will updated
   7. UpdateAllListAsync, update list data to database, all columns will updated
   8. SaveUpdateAsync,save or update data to database
   9. SaveUpdateListAsync,save or update list data to database
   10. DeleteAsync, delete physically data from database
   11. DeleteListAsync, delete physically list data from database
   12. DeleteActiveBoolAsync,for soft delete data, must exist boolean tablefield Activebool ot boolactive in your table,
	  not delete physically, only update to false
   13. DeleteActiveBoolListAsync, for soft delete list data, must exist boolean tablefield Activebool ot boolactive in your table,
	   not delete physically, only update to false
   14. DeleteHeaderDetailAsync, delete data header detail physically (soft delete)
   15. DeleteHeaderDetailListAsync, delete list data header detail not physically (soft delete)
   16. DeleteHeaderDetailActiveBoolAsync, delete data header detail not physically (soft delete)
   17. DeleteHeaderDetailActiveBoolListAsync, delete data header detail not physically (soft delete)
   18. ListDataAsync, make query list to database
   19. ListDataQueryableAsync,make query list to database, Iqueryable is from RepoWrapperAsync Context
   20. DeleteSaveAsync, Delete physically data based on parameter, and save data
   21. DeleteSaveListAsync, Delete physically data based on parameter, and save list data
   20. DeleteSaveActiveBoolAsync, soft delete data based on parameter, and save data
   21. DeleteSaveActiveBoolListAsync, soft delete data based on parameter, and save list data
   22. SaveUpdateDeleteAsync, Save or update or delete data from/to database
   23. SaveUpdateDeleteListAsync, Save or update or delete list data from/to database
   24. SaveUpdateDeleteActiveBoolAsync, Save or update or delete data softly from/to database
   25. SaveUpdateDeleteActiveBoolListAsync, Save or update or delete list data softly from/to database

## Notes 
   1. The Query basicly using EF features, but if in List<SearchField> contains datetime field type or operator = like, 
      will authomatically using DBCommand 		

# HAPPYCoding

contact me at satriansyahw@gmail.com




	   
