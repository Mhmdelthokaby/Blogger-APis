Blogger


Overview
Blogger is a .NET 8-based blogging platform API that provides comprehensive features for managing blog posts, categories, users, comments, post tags, and likes. This project utilizes several design patterns and architectural principles to ensure maintainability, scalability, and security.

Features
Posts: Create, read, update, and delete blog posts.
Categories: Manage categories for organizing blog posts.
Users: User management for bloggers and readers.
Comments: Add and manage comments on posts.
Post Tags: Tag posts with relevant keywords.
Likes: Like and track likes on posts.
Design Patterns and Architecture
Repository & Generic Repository: Abstract data access to improve maintainability and testability.
Specification: Encapsulate business rules for querying data.
Unit of Work: Manage transactions across multiple repositories for consistency.
Onion Layer: Promote separation of concerns and maintain a clean architecture.
Security Module: Implement authentication and authorization mechanisms to secure the platform.
Getting Started
Prerequisites
.NET 8 SDK
SQL Server
Visual Studio or any preferred IDE

Usage
The API endpoints are organized as follows:

Posts
GET /api/posts
GET /api/posts/{id}
POST /api/posts
PUT /api/posts/{id}
DELETE /api/posts/{id}
Categories
GET /api/categories
GET /api/categories/{id}
POST /api/categories
PUT /api/categories/{id}
DELETE /api/categories/{id}
Users
GET /api/users
GET /api/users/{id}
POST /api/users
PUT /api/users/{id}
DELETE /api/users/{id}
Comments
GET /api/comments
GET /api/comments/{id}
POST /api/comments
PUT /api/comments/{id}
DELETE /api/comments/{id}
Post Tags
GET /api/posttags
GET /api/posttags/{id}
POST /api/posttags
PUT /api/posttags/{id}
DELETE /api/posttags/{id}
Likes
GET /api/likes
GET /api/likes/{id}
POST /api/likes
PUT /api/likes/{id}
DELETE /api/likes/{id}
Contributing
Contributions are welcome! Please fork the repository and submit a pull request.

License
This project is licensed under the MIT License - see the LICENSE file for details.

Contact
For any inquiries or feedback, please contact melthokaby22@gmail.com
