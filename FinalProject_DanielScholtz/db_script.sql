--------Script to final project - Daniel Scholtz--------------------------------

USE master;
GO
 
CREATE DATABASE TeacherCourseDB;
GO
 
USE TeacherCourseDB;
GO

-- Create Users table
CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    Password VARCHAR(255),
    JobTitle VARCHAR(50)
);

-- Create Teachers table
CREATE TABLE Teachers (
    TeacherID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100)
);

-- Create Courses table
CREATE TABLE Courses (
    CourseNumber INT PRIMARY KEY,
    CourseTitle VARCHAR(100),
    Duration INT
);

-- Create TeacherCourses table
CREATE TABLE TeacherCourses (
    TeacherCourseID INT PRIMARY KEY,
    TeacherID INT,
    CourseNumber INT
);

-- Populate Users table
INSERT INTO Users (UserID, Password, JobTitle)
VALUES
    (1, 'user1pass', 'Teacher'),
    (2, 'user2pass', 'Program Coordinator'),
    (3, 'user3pass', 'Teacher');

-- Populate Teachers table
INSERT INTO Teachers (TeacherID, FirstName, LastName, Email)
VALUES
    (10, 'Peter', 'Parker', 'john.doe@email.com'),
    (30, 'Mary', 'Jane', 'jane.smith@email.com');

-- Populate Courses table
INSERT INTO Courses (CourseNumber, CourseTitle, Duration)
VALUES
    (101, 'Introduction to SQL', 80),
    (102, 'Web Development Basics', 40),
    (103, 'Data Science Fundamentals', 80);

