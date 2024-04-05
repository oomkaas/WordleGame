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
Example Response: Generated word: rugby
Error Handling: If an error occurs, appropriate HTTP status codes and error messages are returned.



Endpoint: /checkWord
HTTP Method: POST
Endpoint URL: /checkWord
Request Parameters:
  word (string, required)
Response Format: JSON
Example Request:
  Method: POST
  URL: https:///api/Wordle/checkWord
Example Response: golf is a valid word!
Error Handling: If the word parameter is empty, it will return a the message "Invalid input: word cannot be empty."
If the submitted word is not in the word list, it will a message indicating that the word is invalid and not in the word list.
