FROM ubuntu:latest
RUN apt-get -y update
RUN apt-get install -y dotnet-runtime-8.0
#RUN apt-get install -y dotnet-sdk-8.0
RUN apt -y install curl
RUN mkdir /webapp
ADD . /webapp/
CMD ["/bin/bash", "-c", "/webapp/autostart.sh"]
EXPOSE 9595

#nohup ./script.sh >> ./out 2>&1 <&- &
