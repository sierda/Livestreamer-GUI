Livestreamer-GUI
================

View your followed Twitch streamers with Livestreamer instead of with the Flash client.

First-time Setup
================
When you open the project for the first time, add the 'Newtonsoft.Json' as a reference in the c++ project.

Using the program
================

1.Main window

  1. Double-Click a row in the table to watch a stream
  2. 'User Name' field should contain the Twitch username of the user whose followed streams you want to fetch
  3. 'Livestreamer Path' field should contain the path to your "livestreamer.exe"
  4. 'Quality' is like twitches built in quality selector, if a stream doesn't have a certain quality it will fail to load
  5. 'Fetch Streams' button fetches the 50 most recently live channels that the specified user follows
  6. 'Save Settings' saves the text in the top three fields and the status of the two checkboxes to the right for future launches
  7. 'Custom Stream' brings up a small window used to open a stream that isnt listed
  8. 'Auto-Open Chat' automatically opens an html window directed to the users chat room
  9. 'Auto-Fetch streams on startup' automatically fetches streams for the saved user name when the program starts up
  10. Right clicking the table brings up a quick menu that provides the following functionality
    1. 'Open Stream' opens the stream
    2. 'Open Chat' opens the chat window for the user
    3. 'Copy -> IRC Join String' copies an irc join string for the user to the clipboard (/join #<username>)
    4. 'Copy -> Username' copies the twitch username to the clipboard
    5. 'Fetch streams for this user' fetches the followed streams for the specified user (does not save unless you click 'Save Settings')


![alt text](https://camo.githubusercontent.com/e6fd256eff030d70ab7bed79d12429e84e840b9f/687474703a2f2f692e696d6775722e636f6d2f553172327054502e706e67 "Main Window")
