Entity Framework 6 (ORM)

ORM(OBJECT RELATIONAL MAPPING):-

# MODEL CLASSES
# DB CONTEXT
# DB TABLES

3 Approaches:-

a) CODE FIRST
     |
     |--> Building
     |    Model Classes
     |    Using C Sharp and Data Annotations
     |                          |--->Key --> ClassName + Id
     |                          |--->Required
     |                          |--->StringLength
     |
     |---->Building
     |     DB Context
     |          |------>Connection String
     |          |------>DB SET Entries
     |
     |
     |----------------->Linq Statements for CRUD
     |
     |----------------->Migration
                            |
                            |----->Unable - MIGRATION        )
                            |----->ADD - MIGRATION "Label"     }---------PACKAGE MANAGER  
                            |----->Update - Database         ) 


  b) DB FIRST
      |
      |
      |--------->Table Structure Design
      |--------->Creation of EDMX File
      |                        |---------->Model Classes
      |                        |---------->DB Context
      |                        |---------->Update Model from DB
      |
      |------------>Linq Operation

  
   c) Model First
      |
      |------>Creation of EDMX File
      |             |-------->Manual Creation With Entiies With Properties.
      |             |
      |             |-------->Generate Database from Model
      |
      |----------->Linq Qperations
      
      



    






      
