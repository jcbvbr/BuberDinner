pipeline {
    agent any

    stages {
        steps {
            script {
                dockerapp = docker.build("julioveiga/buber-dinner", '-f ./BuberDinner.Api/Dockerfile ./src')
            }
        }
    }
}