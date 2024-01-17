FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["src/Bz.F8t.WebApp/Bz.F8t.WebApp.csproj", "src/Bz.F8t.WebApp/"]
RUN dotnet restore "src/Bz.F8t.WebApp/Bz.F8t.WebApp.csproj"

COPY . .
WORKDIR "/src/src/Bz.F8t.WebApp"
RUN dotnet build "Bz.F8t.WebApp.csproj" -c Release -o /build

FROM build AS publish
RUN dotnet publish "Bz.F8t.WebApp.csproj" -c Release -o /publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html

COPY --from=publish /publish/wwwroot /usr/local/webapp/nginx/html
COPY src/Bz.F8t.WebApp/nginx.conf /etc/nginx/nginx.conf
