# Introduction
 I build a real-world mini social network application for live music lovers called GigHub, where I improved my front-end and back-end development skills. In this project I used techniques like ASP.NET MVC, Web Api, Entity Framework Code First, Boostrap3, HTML5, CSS3, security, object-oriented-design, clean coding, clean arhitecutre, automated testing, dependency injection and much more. 
So musicians can sign up and list their upcoming gigs, and their followers can see all the upcoming gigs on the home page or search for them by artist, genre, or location, and then they can add their favorite gigs to their calendar. Once a musician updates or cancels one of their upcoming gigs, users who are attending that gig will see a notification here on the navigation bar when they log in. After that I refactored application towards a clean, decoupled, and testable architecture. Finally I wrote unit and integration tests for various moving parts.

# Getting Started
TODO: From this project we need to:
1. Create an online account for Visual studio  and then create a project named GigHub
2. Install Visual studio comunity 2017
2. Install 2 plugins from Extension and Updates:
        - Productivity Power Tools 2017
        - Web Essentials 2017
3. Create a ASP.NET Web Application with MVC. 

# Extracting use-cases and create a dependencies between them without authentication
1. Add a gig		
2. My upcoming gigs, All upcoming gigs		
3. Edit a gig, Remove a gig, Add a gig to calendar, Follow an artist, Search, View gig details	
4. View gigs I’m attending, Who I’m following, Gig feed
5. Remove a gig to calendar, Unfollow an artist

# Building a model Using Migrations
 - we use code-first workflow, so we need to enable migrations
	
