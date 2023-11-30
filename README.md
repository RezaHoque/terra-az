# terra-az

1. Pull from main.
2. Build docker: docker build --rm -t terra/todoapi:latest .
3. Run docker: docker run --rm -p 5000:5000 -p 5001:5001 -e ASPNETCORE_HTTP_PORT=https://+:5001 -e ASPNETCORE_URLS=http://+:5000 terra/todoapi
4. Browse: http://localhost:5000/api/todo/hello

Follow this repository to create Azure resources using Terraform : https://github.com/RezaHoque/terraform-azure/blob/main/main.tf

