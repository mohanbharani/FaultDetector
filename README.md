Infrastructure Fault Reporter

A simple web app to report and track infrastructure issues like cut cables, damaged poles, or tangled wires.

Users can pick a location on the map, fill out a short form, and see all reports as markers on the map.

🚀 Tech Used

Frontend: Angular + Leaflet (for maps)

Backend: ASP.NET Core Web API + Memory (Once closed application data will be lost)

Extras: Reactive Forms, simple validation, clean architecture

 How to Run
Backend (API)

Go to the API folder

Run:

dotnet run


API will start at https://localhost:7000

Frontend (Angular)

Go to the frontend folder

Run:

ng serve


App will be available at http://localhost:4200

 What You Can Do

Click on the map to choose a location

Fill out a fault report form

Submit and see your report as a marker on the map

Click markers to view details
