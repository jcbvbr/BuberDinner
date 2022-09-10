pipeline {
    agent any

    stages {
        stage ('Build Image') {
            steps {
                script {
                    dockerapp = docker.build("julioveiga/buber-dinner:${env.BUILD_ID}", '-f ./src/Dockerfile ./src')
                }
            }
        }
    }
}
