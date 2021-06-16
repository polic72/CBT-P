# CBT-P
The communication protocol for the camera bot.

## Basics:
- Connections are made with TCP sending streams of data.
- All commands/responses are terminated with a '|' (vertical bar) character.
- Any movement commands must repeated every second or they will be cancelled.


## Commands (from client to server):
#### Movement
- "Up": Begins to move the camera up.
- "Down": Begins to move the camera down.
- "Left": Begins to move the camera to the left.
- "Right": Begins to move the camera to the right.
- "StopUp": Stops the camera from moving up.
- "StopDown": Stops the camera from moving down.
- "StopLeft": Stops the camera from moving left.
- "StopRight": Stops the camera from moving right.
- "Stop": Stops any and all movement of the camera.

#### Other
- "Disconnect" (might not include): Disconnects the client from the server.


## Responses (from server to client):
- "Ok": When a movement command was received and commenced.
- "Bad": When an unkown command was received.
