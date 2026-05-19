# InventoryHub Reflection

## Overview

For this project, I built InventoryHub using a Blazor WebAssembly front-end connected to an ASP.NET Core Minimal API back-end. Throughout the project, I used Microsoft Copilot to help generate code, fix issues, improve the JSON structure, and optimize some parts of the application.

---

## How Copilot Assisted

### Integration Code

Copilot helped me create the connection between the front-end and back-end. It suggested using `HttpClient` and async methods to retrieve the product data from the API and display it correctly in the Blazor application.

### Debugging Issues

While working on the integration, I ran into problems with API routes, CORS errors, and JSON deserialization. Copilot helped identify the problems faster and suggested fixes like updating the API endpoint, configuring CORS, and adding try-catch blocks for better error handling.

### JSON Structuring

Copilot also helped improve the API response structure by adding nested category objects for each product. This made the JSON cleaner and easier to work with on the front-end.

### Performance Optimization

To improve performance, Copilot suggested reducing unnecessary API calls and implementing memory caching in the back-end. It also helped clean up repetitive code and improve readability.

---

## Challenges Encountered

One of the main challenges was making sure the Blazor front-end communicated correctly with the API. At first, the application failed because of incorrect routes and CORS restrictions. Another issue was handling the nested JSON structure after updating the API responses.

Copilot helped me troubleshoot these problems and made the debugging process much faster.

---

## Lessons Learned

This project helped me better understand how front-end and back-end applications communicate in a full-stack environment. I also learned how important proper JSON structure and error handling are for a stable application.

Using Copilot was useful because it sped up development, suggested cleaner solutions, and helped debug problems when something was not working correctly. It was especially helpful for generating boilerplate code and improving code organization.

Overall, this project gave me more experience working with Blazor, Minimal APIs, JSON handling, and debugging full-stack applications.