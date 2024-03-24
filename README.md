docker build -t demo-quiz .
docker run -it --rm -p 5000:80 --name my-demo-quiz demo-quiz