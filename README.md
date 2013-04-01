1) Build Console Application.
 
2) Ensure Web Application is Startup Project
 
3) Play
 
4) Navigate to: http://localhost:53045/SignalR.Sample/StockTicker.html
 
5) Open your developer console.  You will see the two state change events going from Disconnected to Connecting, and then Connecting to Connected. Every 2 minutes (or so), a long polling request is fired, but a SignalR State Change event is NOT fired.
 
6) Run the console application.  Every 2 minutes (or so), a long polling request is fired which triggers a SignalR State Change event. 
 
Is this the intended behavior??
