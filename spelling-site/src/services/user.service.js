import axios from 'axios'

const userService = {
    getUserById: (studentsId) => {
        const config = {
            method: 'GET'
        }
        return axios(`/api/students/${studentsId}`, config)
            .then(responseSuccessHandler)
            .catch(responseErrorHandler)
    }
}

const responseSuccessHandler = response => response.data;
const responseErrorHandler = error => {
    console.log(error);
    return Promise.reject(error);
}

export default userService;