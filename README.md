Livestreamer-GUI
================

View your followed Twitch streamers with Livestreamer instead of with the Flash client.

First-time Setup
================
When you open the project for the first time, add the 'Newtonsoft.Json' as a reference in the c++ project.

Using the program
================

Main window
  a) Double-Click a row in the table to watch a stream
  b) 'User Name' field should contain the Twitch username of the user whose followed streams you want to fetchN
  c) 'Livestreamer Path' field should contain the path to your "livestreamer.exe"
  d) 'Quality' is like twitches built in quality selector, if a stream doesn't have a certain quality it will fail to load
  e) 'Fetch Streams' button fetches the 50 most recently live channels that the specified user follows
  f) 'Save Settings' saves the text in the top three fields and the status of the two checkboxes to the right for future launches
  g) 'Custom Stream' brings up a small window used to open a stream that isnt listed
  h) 'Auto-Open Chat' automatically opens an html window directed to the users chat room
  i) 'Auto-Fetch streams on startup' automatically fetches streams for the saved user name when the program starts up
  j) Right clicking the table brings up a quick menu that provides the following functionality
    1) 'Open Stream' opens the stream
    2) 'Open Chat' opens the chat window for the user
    3) 'Copy -> IRC Join String' copies an irc join string for the user to the clipboard (/join #<username>)
    4) 'Copy -> Username' copies the twitch username to the clipboard
    5) 'Fetch streams for this user' fetches the followed streams for the specified user (does not save unless you click 'Save Settings')
