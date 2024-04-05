# WordleGame
Testing was documented via Swagger
When generateWord is executed, a random word from the predefined list of sports is chosen and displayed

When checkWord is executed, the input word is checked for whether it is valid or not, and displays its relevant message thereafter

Endpoint: /generateWord
HTTP Method: GET
Endpoint URL: /generateWord
Request Parameters: None
Response Format: JSON
Example Request:
Method: GET
URL: https://api/Wordle/generateWord
Example Response: Generated word: running
Error Handling: If an error occurs, appropriate HTTP status codes and error messages are returned.
