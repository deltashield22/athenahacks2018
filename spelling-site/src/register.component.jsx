import React from 'react'
import { Panel, Button } from 'react-bootstrap'
import Form from 'react-jsonschema-form'

class Register extends React.PureComponent {
    constructor(props) {
        super(props);

        this.onSubmit = this.onSubmit.bind(this);
    }

    onSubmit(r) {
        let formData = r.formData;
        //service call to send formData to database
        //.then(() => location.href("/login"))
    }

    render() {
        const formSchema = {
            type: 'object',
            required: ['firstName', 'lastName',  'email', 'password', 'grade', 'username'],
            properties: {
                firstName: {
                    type: 'string',
                    title: 'First Name'
                },
                lastName: {
                    type: 'string',
                    title: 'Last Name'
                },
                email: {
                    type: 'string',
                    title: 'Email',
                    format: 'email'
                },
                password: {
                    type: 'string',
                    title: 'Password',
                    minLength: 8
                },
                grade: {
                    type: 'integer',
                    title: 'Grade'
                },
                username: {
                    type: 'string',
                    title: 'Username',
                    minLength: 3
                }
            }
        }

        const uiSchema = {
            password: { 'ui:widget': 'password' },
            grade: {'ui:widget': 'updown'}
        }


        return (
            <section>
                <div className="container">
                    <Panel bsStyle="info">
                        <Panel.Heading>
                            <Panel.Title componentClass="h1">Register</Panel.Title>
                        </Panel.Heading>
                        <Panel.Body>
                            <Form className="col-lg-8 col-lg-offset-2 col-md-8 col-md-offset-2 col-sm-8 col-sm-offset-2"
                                noHtml5Validate={true}
                                schema={formSchema}
                                uiSchema={uiSchema}
                                onSubmit={this.onSubmit}>
                                <div className="row">
                                    <div className="col-lg-6">
                                        <Button type="submit" bsStyle="success">Submit</Button>
                                    </div>
                                </div>
                            </Form>
                        </Panel.Body>
                    </Panel>
                </div>
            </section>
        )
    }

}

export default Register;